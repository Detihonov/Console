using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace AsyncAwait
{
    internal class ThreadPoolWorkerResult<TResult>
    {
        private readonly Func<object, TResult> func;
        private TResult result;

        public ThreadPoolWorkerResult(Func<object, TResult> func)
        {
            this.func = func ?? throw new ArgumentNullException(nameof(func));
            result = default;
        }

        public bool Success { get; set; } = false;
        public bool Completed { get; set; } = false;
        public Exception Exception { get; set; } = null;
        public TResult Result
        {
            get
            {
                while (Completed == false)
                {
                    Thread.Sleep(150);
                }

                return Success == true && Exception == null ? result : throw Exception;
            }
        }

        public void Start(object state)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadExecution), state);
        }

        private void ThreadExecution(object state)
        {
            try
            {
                result = func.Invoke(state);
                Success = true;
            }
            catch (Exception ex)
            {
                Exception = ex;
                Success = false;
            }
            finally
            {
                Completed = true;
            }
        }
    }
}

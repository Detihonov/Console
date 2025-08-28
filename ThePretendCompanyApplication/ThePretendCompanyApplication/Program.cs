using TCPData;
using TCPExtensions;
using ThePretendCompanyApplication;

List<Employee> employeesList = Data.GetEmployees();
List<Department> departmentsList = Data.GetDepartments();

Example.GetHighSalariedEmployees();

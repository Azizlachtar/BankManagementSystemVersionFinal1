namespace BankManagementSystemVersionFinal1.Models
{
    public class Agent: Employee
    {
        public Agent() { }
        public Agent(string name, string address, int phoneNumber, Department department,BankBranch bankbranch) : base(name, address, phoneNumber, department, bankbranch)
        { }
    }
}

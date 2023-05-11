namespace BankManagementSystemVersionFinal1.Models
{
    public class Manager: Employee
    {
        public Manager() { }
        public Manager(string name, string address, int phoneNumber, Department department,BankBranch bankbranch) : base(name, address, phoneNumber, department, bankbranch)
        { }
        public void ApproveLoan(Loan loan)// ikhali el etat loan approval
        {

        }
    }
}

using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector:Employee
    {
       
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            if (request.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                Context context = new Context();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Area Director - Jason Blueberry";
                customerProcess.Description = "Withdrawal Transaction Confirmed, The Customer Was Paid The Requested Amount";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }

            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                Context context = new Context();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Area Director - Jason Blueberry";
                customerProcess.Description = "Since The Withdrawal Amount Exceeded The Amount The Area Director Could Pay Daily, " +
                    "The Transaction Could Not Be Completed, The Maximum Amount The Customer Can Withdraw Per Day Is " +
                    "400000 Dollars, " +
                    "And For More, He/She Must Come To The Branch More Than Once.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}

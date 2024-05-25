using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Manager:Employee
    {
       
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            if (request.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                Context context = new Context();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Manager - Cindy John";
                customerProcess.Description = "Withdrawal Transaction Confirmed, The Customer Was Paid The Requested Amount";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }

            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                Context context = new Context();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Manager - Cindy John";
                customerProcess.Description = "Since The Withdrawal Amount Exceeded The Amount The Manager Could Pay Daily, " +
                    "The Transaction Was Forwarded To The Area Director.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}

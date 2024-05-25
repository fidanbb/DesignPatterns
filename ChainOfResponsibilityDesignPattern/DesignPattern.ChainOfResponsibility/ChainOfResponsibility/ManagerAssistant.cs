using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class ManagerAssistant : Employee
    {
       
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            if (request.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                Context context = new Context();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Assistant Manager - Emma Swan";
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
                customerProcess.EmployeeName = "Assistant Manager - Emma Swan";
                customerProcess.Description = "Since The Withdrawal Amount Exceeded The Amount The Assistant Manager Could Pay Daily, " +
                    "The Transaction Was Forwarded To The Manager.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}

using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        
        public override void ProcessRequest(CustomerProcessViewModel request)
        {

            if (request.Amount<=100000)
            {
                Context context = new Context();
                CustomerProcess customerProcess = new CustomerProcess();

                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Treasurer - Andy Black";
                customerProcess.Description = "Withdrawal Transaction Confirmed, The Customer Was Paid The Requested Amount";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if(NextApprover !=null)
            {
                Context context = new Context();
                CustomerProcess customerProcess=new CustomerProcess();

                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Treasurer - Andy Black";
                customerProcess.Description = "Since The Withdrawal Amount Exceeded The Amount The Treasurer Could Pay Daily, " +
                    "The Transaction Was Forwarded To The Assistant Manager.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}

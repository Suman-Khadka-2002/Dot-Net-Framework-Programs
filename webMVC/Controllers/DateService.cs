namespace webMVC.Controllers
{
    public class DateService : IDateService
    {
        public DateTime GetDate()
        {
            return System.DateTime.Now;
        }
    }
}

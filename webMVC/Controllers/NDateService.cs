namespace webMVC.Controllers
{
    public class NDateService:IDateService
    {
        public DateTime GetDate()
        {
            return System.DateTime.Now.AddYears(57);
        }
    }
}

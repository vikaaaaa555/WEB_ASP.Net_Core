using Microsoft.AspNetCore.Mvc;

namespace WEB_153503_Zviagintsava.ViewsComponents
{
    public class Cart : ViewComponent
    {
        private double cost = 0.0;
        public string Invoke() => $"{cost:N2} руб";
    }
}
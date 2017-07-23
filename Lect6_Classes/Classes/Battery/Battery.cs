namespace MobilePhoneDevices
{
    public class Battery
    {
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        
        public Battery()
        {

        }
        public Battery (string model)
        {
            this.model = model;
        }

        public Battery (double hoursId, double hoursT)
        {
            this.hoursIdle = hoursId;
            this.hoursTalk = hoursT;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se4.OOP
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal _extraFee;

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAdress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            _extraFee = extraFee >= 0 ? extraFee : 0;
        }

        public decimal ExtraFee
        {
            get { return _extraFee; }
            set
            {
                if (value >= 0)
                    _extraFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + _extraFee; }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment\n");
            Console.WriteLine("Tracking Code : " + TrackingCode);
            Console.WriteLine("Extra Fee     : " + ExtraFee + " EGP");
            Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
        }

        public string GetTrackingStatus()
        {
            return "Shipment " + TrackingCode + " is Out for Delivery.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }
}

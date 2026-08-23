using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se4.OOP
{
    public static class DeliveryHelper

    {

        public static void PrintShipmentDetails(Shipment shipment)

        {

            if (shipment != null)

            {

                shipment.PrintShipment();

            }

        }

    }
}

using oop01;

namespace oop01
{
    class Program
    {
        static void Main(string[] args)
        {

            #region q1

            //a- the copy value will modify but the original variable not modified

            //b- the copy value will modify and the original variable will modify
            #endregion

            #region q2
            //a):

            //1- fields is public
            //2- no validation
            //3- no protection

            //b):
            // we can make fields private and make public properties provide controlled access and allow validation before changing the values.
            #endregion

            #region q3
            DeliveryAddress deliveryAddress01 = new DeliveryAddress("cairo", "Haram", 18);
            DeliveryAddress deliveryAddress02 = deliveryAddress01;
            Console.WriteLine(deliveryAddress01.GetFullAddress());
            Console.WriteLine(deliveryAddress02.GetFullAddress());

            deliveryAddress02 = new DeliveryAddress("giza", "tersa", 20);

            Console.WriteLine(deliveryAddress01.GetFullAddress());
            Console.WriteLine(deliveryAddress02.GetFullAddress());


            #endregion

            #region part02

            DeliveryCenter deliverycenter = new DeliveryCenter();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Shipment {i + 1}");

                Console.Write("Tracking Code: ");
                string trackingCode = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Weight: ");
                int weight = int.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal deliveryFee = decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Street: ");
                string street = Console.ReadLine();

                Console.Write("Building Number: ");
                int buildingNumber = int.Parse(Console.ReadLine());

                DeliveryAddress destination = new DeliveryAddress(city, street, buildingNumber);

                Shipment shipment = new Shipment(
                    trackingCode,
                    description,
                    weight,
                    deliveryFee,
                    destination
                );

                deliverycenter.AddShipment(shipment);
            }




            for (int i = 0; i < 3; i++)
            {
                deliverycenter[i].PrintShipment();
                Console.WriteLine();
            }

            Console.Write("Enter tracking code to search: ");
            string searchCode = Console.ReadLine();

            Shipment found = deliverycenter[searchCode];


            if (!string.IsNullOrWhiteSpace(found.TrackingCode))
            {
                found.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }




            DeliveryAddress address01 = new DeliveryAddress("Cairo", "Tahrir", 10);

            DeliveryAddress address2 = address01;

            address2.City = "Giza";
            Console.WriteLine(address01.GetFullAddress());
            Console.WriteLine(address2.GetFullAddress());

            #endregion

        }

    }

}

namespace se4.OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*a)What is Abstraction in OOP?
             * Hiding the complex background implementation
             * details and showing only the essential features to the user
             * b)Why is it one of the four pillars of OOP?
             * Reduces system complexity, hides unnecessary details to improve security, 
             * and allows underlying code to change without breaking other parts of the application.        
             */
            #endregion
            #region Q2
            /*a)Difference between Abstract Class and Interface
             * Abstract Class: Represents an "is-a" relationship. Can contain both implemented methods and abstract methods,
             * as well as instance variables.
             * Interface: Represents a "can-do" relationship. Acts as a contract defining required behaviors, 
             * usually consisting only of abstract method signatures without state.
             * 
             * b)When to choose an Interface over an Abstract Class?
             * When you need to define a common behavior across unrelated classes (e.g., both a Car and a Robot implementing Chargeable),
             * or when you need multiple inheritance of type.
             * 
             * c)Inheritance and Implementation Rules
             * Multiple Abstract Classes: No, a class can inherit from only one abstract class.
             * Multiple Interfaces: Yes, a class can implement multiple interfaces at the same time.        
             */
            #endregion
            #region Practical
            //DeliveryAdress address = new DeliveryAdress("Cairo", "El-Tahrir St", 15);
            //StandardShipment standard = new StandardShipment("SH001", "Books Package", 2.5m, 40m, address);
            //ExpressShipment express = new ExpressShipment("SH002", "Urgent Documents", 1.0m, 60m, address, 20m);
            //InternationalShipment international = new InternationalShipment("SH003", "Electronics", 5.0m, 100m, address, "UAE", 50m);
            //DeliveryCenter center = new DeliveryCenter("Main Cairo Center");
            //center.AddShipment(standard);
            //center.AddShipment(express);
            //center.AddShipment(international);
            //Console.WriteLine("--- E. All Shipment Details ---");
            //center.PrintAllShipments();
            //Console.WriteLine("\n--- F. Tracking Status of Every Shipment ---");
            //center.PrintTrackingStatuses();
            //Console.WriteLine("\n--- G. Insurance Cost of Every Shipment ---");
            //DeliveryReport.PrintInsurance(standard);
            //DeliveryReport.PrintInsurance(express);
            //DeliveryReport.PrintInsurance(international);
            //Console.WriteLine("\n--- H. ITrackable[] Polymorphism ---");
            //ITrackable[] trackableItems = new ITrackable[] { standard, express, international };
            //foreach (ITrackable t in trackableItems)
            //{
            //    DeliveryReport.PrintShipment(t);
            //}
            //Console.WriteLine("\n--- I. IInsurable[] Polymorphism ---");
            //IInsurable[] insurableItems = new IInsurable[] { standard, express, international };
            //foreach (IInsurable i in insurableItems)
            //{
            //    DeliveryReport.PrintInsurance(i);
            //}
            #endregion
        }
    }
}

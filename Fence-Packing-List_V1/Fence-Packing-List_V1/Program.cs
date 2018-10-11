using System;

namespace Fence_Packing_List_V1
{
    class Program
    {
        /*
         * Purpose:                     Create a costed Packing Slip reflecting the 
         *                              materials needed to build a playground fence
         *                              
         * Input:                       Dimensions of rectangular playground
         *                              Height and width of a single gate   
         *                              Distance between posts (usually 6-8 feet)
         *                              Type of paint (Premium)
         *                              Type of fence (Cedar)
         *                              
         * Process:                     Find square feet of fencing material
         *                              without the gate linear feet. Fence cost is found with
         *                              product of cedar price and amount
         *                              
         *                              Calculate the number of posts by dividing the usual post 
         *                              distance by the lineal feet of fencing material. Add one
         *                              to account for the corner post
         *                              
         *                              Gate size is the product of width and height. The
         *                              gate amount is 1 in this example. Product of gate cost and
         *                              gate amount is the price of the gate.
         *                              
         *                              Railing is the lineal feet of railing which is the 
         *                              product of width and height times two to measure top and 
         *                              bottom rails. Product of $ 0.69 and railing is the railing
         *                              price.
         *                              
         *                              Amount of paint is based on square feet of 
         *                              fencing material.Each gallon contains 400 sq ft worth of 
         *                              paint.  Paint is measured per whole quarts. Divide the gallon  
         *                              by 4 to find the quarts. Product of quarts and premium
         *                              paint is quarts price.
         *                              
         *                              
         * Output:                      Amount of fencing material required
         *                              Extended price of fencing material
         *                              Lineal feet of railing required
         *                              Extended price of lineal railing
         *                              Amount of posts required
         *                              Extended price of posts
         *                              Quarts of paint required
         *                              Extended price of paint
         *                              Extended price of gates
         *                              Net Price of all components
         *                              Total GST of all component (5%)
         *                              Total Price of playground
         *           
         * Written By:                  Terence Lee
         * 
         * Date Modified                2018.09.23
         *           
         * */

        // Method that prompts user and outputs a double
        static double ReadDouble(string prompt, string spaces = "")
        {

            Console.Write($"Enter the {prompt,-25} >> ");
            double var = double.Parse(Console.ReadLine());

            return var;
        }

        // Method that calculates the extended cost with added GST
        static double ExtendedCost(double cost, double GST)
        {
            double totalCost;

            double totalTax = cost * GST;
            totalCost = cost + totalTax;

            return totalCost;
        }

        // Calculates extra 10% waste cost in price and materials
        static double WasteCost(double result)
        {
            double totalResult;

            totalResult = (result * 1.10);

            return totalResult;
        }

        // Displays the amount of materials required and price w/ tax of each component
        // Also formats the Invoice and Packing slip according to the requirements
        static public double PriceAmount(double amount, double costTax, string description,
            double partCost, string measure = "", string atChar = "")
        {

            Console.WriteLine($"  {amount,6:0.0}   {measure,-6}{description,-25}" +
                $"{atChar,-1} {partCost,8:##.00}{" =",-1} {costTax,12:0.00}");

            return 0;

        }

        // Start here
        static public void Main(string[] args)
        {

            double width, length, height;                                                      // Initial variables that aren't outputed in 
            double gateWidth, gateHeight;                                                      // final invoice
            double postDistance;                                                               //                                                               
            double totalFence, fencePrice;                                                     // Variables used in final calculations
            double postNumber, postPrice;                                                      // Format of methods is amount then price
            double railingAmount, railingCost;                                                 //
            double gateSize, gatePrice;                                                        //
            double quarts, paintPrice;                                                         //
            double totalTax;                                                                   // Final price values
            double netPrice;                                                                   //
            double totalPrice;                                                                 //

            const double FENCE = 4.50;                                                         // Prices of each constant material type as well 
            const double POSTS = 23.99;
            const double RAILING = 0.49;
            const double PAINT = 11.99;
            const double TAX = 0.05;                                                           // Constant GST

            const double GATE_AMOUNT = 1;                                                      // For the set number of gate(s) allowed

            width = ReadDouble("width of the playground", "");                                 // Runs ReadDouble method that takes user inputs
            length = ReadDouble("length of the playground", "");                               // converts to double and stores them     
            height = ReadDouble("height of the fence", "");
            postDistance = ReadDouble("space between posts", "");
            gateWidth = ReadDouble("width of the gate", "");
            gateHeight = ReadDouble("height of the gate", "");

            double gateExtra = (gateHeight - height) * 4;

            gateSize = (gateHeight * gateWidth);                                               // total gate height and width                                                                                          
            gatePrice = 120 + (15.75 * gateSize);                                              //price of gate
            gateSize = gateWidth * gateHeight;

            double side = (length * height * 2);                                                // sides are unaffected by gate
            double front = (width * height) - gateSize + gateExtra;                             // where the gate is
            double back = (width * height);                                                   // back where there is no gate
            totalFence = side + front + back;

            double fenceWasteAmount = WasteCost(totalFence);                                    // Waste cost for the fence use wasteCost method            
                                                                                                // total fencing of all sides without gate           

            fencePrice = fenceWasteAmount * 7.25;                                               // material Price

            railingAmount = 2 * ((2 * width + 2 * length) - gateWidth);                         // Lineal railing for top and bottom           
            double railingWasteAmount = WasteCost(railingAmount);
            railingCost = 0.69 * railingWasteAmount;                                            // railing cost        

            postNumber = Math.Ceiling(((railingAmount + gateWidth) / 2) / postDistance);        // find number of posts by dividing total lineal footage by number of posts
                                                                                                // Rounding up
            postNumber++;                                                                       // Handle extra post on the corner
            postPrice = 23.99 * postNumber;                                                     // Multiplying with price of each post


            quarts = (totalFence / 100);                                                        // Find quarts by using how much paint each quart would use, which is 
                                                                                                // 100 sq. ft
            quarts = Math.Ceiling(quarts);                                                     // Round quart amount up to next whole number                              
            quarts = 2 * quarts;                                                               // paint calculates inside and outside

            paintPrice = 15.99 * quarts;                                                       // calculate cost of paint per quart

            // price of all components with tax ----------------------- see if tax is calculated before or after
            double extendedFence = ExtendedCost(fenceWasteAmount, TAX);
            double extendedPost = ExtendedCost(postPrice, TAX);
            double extendedRailing = ExtendedCost(railingWasteAmount, TAX);
            double extendedGate = ExtendedCost(gatePrice, TAX);
            double extendedPaint = ExtendedCost(paintPrice, TAX);

            Console.WriteLine();

            Console.WriteLine("Invoice and Packing Slip");                                     // Title of order slip

            Console.WriteLine();

            // Display packing list 
            PriceAmount(fenceWasteAmount, fencePrice, "Fencing Material", FENCE, measure: "^ft.", atChar: "@");
            PriceAmount(postNumber, postPrice, "Posts", POSTS, measure: "   ", atChar: "@");
            PriceAmount(railingWasteAmount, railingCost, "Railing", RAILING, measure: " ft.", atChar: "@");
            Console.WriteLine($"  {GATE_AMOUNT,6:0.0}{"         "}{"Gate",-35}{" =",-1} {gatePrice,12:0.00}");
            PriceAmount(quarts, paintPrice, "Paint", PAINT, measure: "qts.", atChar: "@");

            Console.WriteLine();
            // Price of all materials without GST and waste
            netPrice = fencePrice + postPrice + railingCost + gatePrice + paintPrice;
            // Total cost of GST  
            totalTax = netPrice * TAX;
            // Total cost including all waste cost and GST
            totalPrice = extendedFence + extendedRailing + postPrice + gatePrice + paintPrice + totalTax;
            // Display the variables
            Console.WriteLine($"{"Net price",52} {"=",-1} {netPrice,12:0.00}");
            Console.WriteLine($"{"GST",52} {"=",-1} {totalTax,12:0.00}");
            Console.WriteLine($"{"Total",52} {"=",-1} {netPrice + totalTax,12:0.00}");

            Console.ReadLine();
        }
    }
}

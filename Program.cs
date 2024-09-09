double tips =0.0; 
int numberOfSandwiches = 0; 
string customerName; 
int numberOfToppings = 0; 

const double COST_OF_SANDWICH  = 4.75; 
const double COST_OF_TOPPING  = 0.55; 
const double DISCOUNT_AMOUNT = 0.10; 

int userInput= 0; 
double totalSandwichCost = 0.0; 
double totalToppingCost = 0.0; 
double baseCost = 0.0;

System.Console.WriteLine("Hello Customer! Welcome to Sherlenthia's Sandwich Shop! Where the Best Sandwiches are Made! What is your name? \n ");

customerName = Console.ReadLine();

System.Console.WriteLine("Hello " + customerName + "! How many number of sandwiches will you be ordering? \n ");

userInput = int.Parse(Console.ReadLine());

numberOfSandwiches = userInput;

System.Console.WriteLine("Okay! What's the number of toppings you want? \n");

userInput = int.Parse(Console.ReadLine());

numberOfToppings = userInput;

System.Console.WriteLine ("Alright! Those Sandwiches will be heading your way! How much will you like to tip? \n"); 

tips = double.Parse(Console.ReadLine());

totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
totalToppingCost = COST_OF_TOPPING * numberOfToppings;
baseCost = totalSandwichCost + totalToppingCost;

double orderCost = tips + baseCost * (1-DISCOUNT_AMOUNT);

 double roundedorderCost = Math.Round(orderCost, 2);

System.Console.WriteLine("Thank you for your order! Your total balance was: $" + roundedorderCost + ". Happy National Sandwich Day!\n");


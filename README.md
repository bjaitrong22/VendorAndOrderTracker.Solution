# Application Name

VendorAndOrderTracker.Solution

#### Brief Description

VendorAndOrderTracker.Solution is a Vendor and order tracking application intended for a bakery. The user can create a list of Vendors and their orders. Once saved, the user can click on the vendor's name and the application will provide the orders associated with that vendor and/or allow the user to enter new orders.

#### Author

By Bai Jaitrong

## Technologies Used
  * Visual Studio code 1.73.1
  * .NET 6 SDK
  * C# 10
  * MsTest
  
## Description

The application will present the user with the following message on the home page:


 Welcome to Pierre's Bakery Vendor and Order Tracker 
                  
                  View Vendors

The user will click on the View Vendors link to the Vendor's page to see their list of Vendors that they have entered. If no vendors have been entered,then there will be message indicating that there are not vendors in the system. Vendors can be added by clicking the Add a new vendor link or they can click on the Back Home link to return to the home page without adding a vendor. Below is the message the user will initial see on the Vendors page along with the two links. 

                        Vendors
              No Vendors have been added yet.

                    Add a new vendor
                        Back Home

The Add a new vendor link will take the user to the Add Vendor page where the user can enter their new vendor's information. Below is what they will see, two text field to enter the requested information, an add button to submit the information, and links back to the home page and Vendors page, see below. 

                      Add a Vendor
         Enter the Vendor's information here:

 Vendor's Name:           Vendor's Description:          Add

                         Back Home

                       Back To Vendors

Once the infomation has been entered, the application redirects the user back to the home page where they can click on the View Vendors link to see the list of vendor(s). Below is an example of the Vendors page with two vendors listed. 

                         Vendors
                Suzy's Cafe: Restuarant
                Tom's Bistro: Restuarant

                      Add a new vendor
                          Back Home

To add orders to a specific vendor, the user can click on vendor's information on the list, and the link will take the user to the Add Order page for that vendor, below is an example of the page:

                           Suzy's Cafe 's Orders
                              Add a new Order

                             Back To Vendor List
                                   Back Home

They then can click the Add a new order link to enter the order information for the vendor selected; In the above example, the order will be linked to Suzy's Cafe. Below is what the user will see on Add a new order page:

              Add a new order to Suzy's Cafe
Order Title:   Order Description:   Order Price:  Add Order

The user will enter a title, description, and price for the order. Afterwards, they will then click on the Add order. They will then be taken to the selected vendor's order page and see that the has been added to the vendor's order list, see below example:

                 Suzy's Cafe's Orders
                      1. Bread

                    Add a new Order
                   Back To Vendor List
                        Back Home

The user can then click on the order to view the order details or click on the other links provided. In the above example, the order is titled Bread. Below is an example of the order details page:

                 Suzy's Cafe's Order Details:
                             Bread
                       20 loaves, French
                        Price: $300
               Date And Time: 12/17/2022 20:43
                         
                         Add another Order
                          View All Vendors

If the user leaves any field blank when addina a Vendor or an order or entering a negative price, the application will route them to the Error page with the message below:

Oops! You can't leave a field blank or enter a negative dollar amount. Please try again.
                 
                                   Add a new vendor
                            Add an Order for an existing vendor

## Setup/Installation Requirements

  1. Create a repository in your GitHub account for this project by selecting the green New button on the upper left side of the screen and follow the instruction. The button is across from Recent Repositories. You will need the URL this repository in step 7.

  2. Clone VendorAndOrderTracker.Solution repository to your desktop or a subdirectory in your desktop by running the command: 
  
    git clone https://github.com/bjaitrong22/VendorAndOrderTracker.Solution.git

    * Be careful not to clone the repository inside a local repository. Otherwise, you will have a nested git respository.

### Removing the original remote repository and adding your remote repository

  3. Navigate to the top level/root of the currency-exchanger directory using your command line.

  4. Run the following command to find the name of the remote repository attached to this project so that it can be removed before adding your remote repository:

    git remote -v

    bj	https://github.com/bjaitrong22/VendorAndOrderTracker.Solution.git (fetch)
    bj	https://github.com/bjaitrong22/VendorAndOrderTracker.Solution.git (push

    * you will get a response above, and the remote repository's nick name/identifier is bj or you may see it as origin.

 5. Enter the command: 
 
    git remote rm origin 
    
    If the identifier is origin. Replace origin if the identifier is something else. So if the identifier is bj, you would enter git remote rm bj. 
      
6. Confirm that the prior remote repository has been removed by running the command below:

    git remote -v  
      
    * Nothing should show up. That means the remote has been removed. If it hasn't been removed correctly, return to step 4. & 5. 
      
7. Now you can add your remote repository by running the command below (be sure to remove the brackets) using your project's git repository url.  

    git remote add origin [your-project-url-here]. 
      
    * You can use an identifier other than origin. Copy the URL from your GitHub project repository by clicking the green CODE drop down menu on your GitHub repository and put it at the end of the command above. Which you should already have from step 1.
      
8. You can confirm that the new remote is correctly linked by running the command: 

    git remote -v

### Pushing .gitignore file from the clone VendorAndOrderTracker.Solution
    
9. Before pushing any changes to your remote repository,run the command 

    git add .gitignore 
    git commit -m "Add .gitignore file."
    git push [your-remote-Identifier] main
    
  This will let GitHub know what files not to upload to GitHub from your local repository.

### You are now ready to work on the project

10. Open the project using your text editor of your choosing.

12. Interacting with VendorAndOrderTracker test cases:

    * Navigate to the subdirectroy VendorAndOrderTracker.Solution/VendorAndOrderTracker.Tests using your command line.

    * To install the required packages listed in VendorAndOrderTracker.Tests.csproj file, run the command "dotnet restore".
     
    NOTE: the command will automtically create new obj directories in the VendorAndOrderTracker and VendorAndOrderTracker.Tests subdirectories. Do not touch these files. If they are deleted by accident or updates are made to one of .csproj files or both , you can follow step 12 and run the "dotnet restore" again to restore the files or apply the updates form the .csproj file.  

    Also, leave out the quotes when running the terminal commands. The quotes are just for emphasis.

    * You can now run the test that has already been put in place by running the command "dotnet test" in the subdirectory VendorAndOrderTracker.Solution/VendorAndOrderTracker.Tests. 
  
11. To build and run the project using MSBuild:

     * Navigate to the subdirectroy VendorAndOrderTracker.Solution/VendorAndOrderTracker using your command line.

     * First, run the command "dotnet build".

     * Afterwards,run the command "dotnet run". You can also run "dotnet watch run" if you would like the system to update the web pages as you experiment with the code.
    
## Known Bugs

  * On the ordered list of the vendors' orders, the orders on the list does not stay left justified if the order follwing it has a longer title/name.

# License
 * Portfolio is licensed under the terms of GNU AFFERO GENERAL PUBLIC LICENS Version 3, 19 November 2007 ( change if you are using a different license)


 
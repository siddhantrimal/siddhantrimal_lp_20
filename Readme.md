# LogPoint Set-20 | Solution by [@siddhantrimal](https://siddhantrimal.github.io)

## NAVIGATION
Use the table given below to explore the solutions easily. *Click the #REF link to jump to solution.*


|#REF | NAVIGATE TO |
---: | :---
[Question-1](#question-no1)| SQL
[Question-2](#question-no2)| .NET
[Question-3](#question-no3)| Theory: Test Cases
[Question-4](#question-no4)| Theory: Thought Project

---

### Question no.1 

* Answer: The required SQL Query is as follows
    ```sql
    SELECT
        d.dep_Name AS Department,
        e.emp_Name AS Employee,
        e.emp_Salary AS Salary
    FROM Employee AS e 
    INNER JOIN Department AS d ON d.dep_Id=e.emp_DepartmentId
    WHERE NOT EXISTS(
        SELECT null
        FROM Employee AS innere
        WHERE innere.emp_DepartmentId=e.emp_DepartmentId
        AND innere.emp_Salary>e.emp_Salary
    )
    ORDER BY e.emp_DepartmentId;
    ```
    OUTPUT:

    ![Fig: Output Screen "The Required SQL Query"](https://cloud.githubusercontent.com/assets/18209220/26512863/44affa6c-4288-11e7-9f64-5910bff3b950.PNG)
* Technology/Software used:
    * MS SQL Server 2017/MS SQL Server Management Studio 2017
* Showing my work
    * Database `question01db` was created first.
    * Then the Department table was created, according to hierarchial dependency.
        ```sql
        CREATE TABLE Department (
            dep_Id int NOT NULL IDENTITY(1,1),
            dep_Name varchar(100),
            PRIMARY KEY (dep_Id)
        );
        ```
        ![](https://cloud.githubusercontent.com/assets/18209220/26512861/44a303ca-4288-11e7-9f04-d45a43711d33.PNG)
    * Likewise, now Employee table was also created. The field `DepartmentId` in Employee table is a Foreign Key; Hence, the reason to create this table later. (*Alternatively, could have altered Employee table later*)
        ```sql
        CREATE TABLE Employee (
            emp_Id int NOT NULL IDENTITY(1,1),
            emp_Name varchar(100),
            emp_Salary int,
            emp_DepartmentId int,
            PRIMARY KEY (emp_Id),
            FOREIGN KEY (emp_DepartmentId) REFERENCES Department(dep_Id)
        );
        ```
    * Data Insertion
        * Scheme: Department table is first populated to reference in Employee table.
        ```sql
        INSERT INTO Department(
            dep_Name
        )
        VALUES(
            'IT'
        ),
        (
            'Sales'
        );
        ```

        * Verifying insertion:

            ![](https://cloud.githubusercontent.com/assets/18209220/26512862/44a996d6-4288-11e7-9a7d-340441fd3ab6.PNG)


        ```sql
        INSERT INTO Employee(
            emp_Name,
            emp_Salary,
            emp_DepartmentId
        )
        VALUES(
            'Joe',
            70000,
            1
        ),
        (
            'Henry',
            80000,
            2
        ),
        (
            'Sam',
            60000,
            2
        ),
        (
            'Max',
            90000,
            1
        );
        ```
    * After all this, [the query, from the answer above](#question-no1), was run.
* Also available as a [file](q1.txt)
* **END OF QUESTION-01**

---

### Question no.2
* Answer: `232792560`
* Solved on .NET Framework Console in VS2017
    * Solution Available at `Question02\Question02.sln`
    ```cs
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Question02
    {
        class Program
        {

            public const int upperrange = 20;

            static void Main(string[] args)
            {
                bool flag = true;
                var i = 0;
                var testposnum = 1;

                while (1==1)
                {
                    for (i = 1; i <= upperrange; i++)
                    {
                        if (i==testposnum) {
                            continue;
                        }
                        if (testposnum % i != 0) {
                            flag = false;
                            break;
                        }
                        /*Uncomment the line below to see process*/
                        //Console.WriteLine("Check " + testposnum + " against (i=" + i + ") ->  flagState=" + flag);
                    }
                    if (!flag)
                    {
                        testposnum++;
                        flag = true;
                    }
                    else {
                        break;
                    } 
                }
                Console.WriteLine("The required answer is "+testposnum);
                Console.ReadLine();
            }
        }
    }
    ```

* Output:

    ![](https://cloud.githubusercontent.com/assets/18209220/26512864/44b502f0-4288-11e7-84c0-bf8afb4b7759.PNG)
* Also available as a [file](q2.txt)
* **END OF QUESTION-02**

---

### Question no.3
* TEST CASES:
    
    ---

    **Title:** Browse Button - validate opening `.CSV` file and reading content

    ---

    **Test Case Id:** 001

    **Description:** The user should be able to open and view their `.CSV` file

    **Precondition:** The user should be shown a browse dialog box that allows selection of `.CSV` files.

    **Assumptions:** a supported browser is being used, there are some `.CSV` files in the browse directory.

    **Test Steps:**
    1. Navigate to the button segment in the webpage or form
    1. Click on the button
    1. Select a `.CSV` file from the list
    1. Click Open

    **Expected Result:** The browse dialog should show files and after selection, a page or modal displaying the content of the `.CSV` file should open.

    **Actual Result:** The browse dialog shows all files. On selection of one of the .CSV files, a page displaying the content of the .CSV file opens. On selection of any other file-type, an error occurs.

    **Pass/Fail:** Fail

    ---

    **Test Case Id:** 002

    **Description:** The user should be able to open and view their `.CSV` file

    **Precondition:** The user should be shown a browse dialog box that only allows selection of `.CSV` files.

    **Assumptions:** a supported browser is being used, there are some `.CSV` files in the browse directory.

    **Test Steps:**
    1. Navigate to the button segment in the webpage or form
    1. Click on the button
    1. Select a file from a list of only `.CSV` files
    1. Click Open

    **Expected Result:** The browse dialog should only show `.CSV` files and after selection, a page or modal displaying the content of the file should open.

    **Actual Result:** The browse dialog shows only `.CSV` files. On selection of one of the files, a page displaying the content of the file opens.

    **Pass/Fail:** Pass

    ---

* Also available as a [file](q3.txt)
---

### Question no.4   
* Answer:

    [Steve Banks](https://www.forbes.com/sites/kevinready/2012/08/28/a-startup-conversation-with-steve-blank/) defines startups as "a temporary organization used to search for a repeatable and scalable business model". According to this definition, it is clear as day that the ***Agile mode of development*** should be chosen for the SDLC.

    My plans would encompass the usual model of development wrapped around the scope of a T-shirt manufacturing company as follows:
    1. Elicitation
        * Meetup / JAD Sessions
        * Understanding Workflow
        * Mock Order
    1. Analysis
        * System Analysis
    1. Design
        * System Design
    1. Development
        * Coding
        * Testing
            * Pilot
            * Usability
    1. Deployment
    1. Maintainance

    The aforementioned project guideline will enable the project to complete in feasible time.
* Also available as a [file](q4.txt)

---

# LogPoint Set-20 | Solution by @siddhantrimal

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

    ![Fig: Output Screen "The Required SQL Query"](images\screenshots\img-03.png)
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
        ![](images/screenshots/img-01.png)
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

            ![](images\screenshots\img-02.png)


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

    ![](images\screenshots\img-04.png)
* Also available as a [file](q2.txt)
* **END OF QUESTION-02**

---

### Question no.3

---

### Question no.4   

---

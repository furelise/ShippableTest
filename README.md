# ShippableTest


The working URL is available at http://www.shippablefurelise.somee.com

Explaination:

1. This program takes a URL as input.
2. Through client side regular expression validation it validates if the entererd URL is a github URL in the below format or not:
    https://github.com/xxxxxxxxxx
3. After clicking on 'Get Issue Details' button, the URL in format https://github.com/xxxxxxxxxx is converted to URL in format https://api.github.com/repos/xxxxxxxxxx
4. Then, this new URL is passed through more validations and changes so that this application allows all of the below
   https://github.com/xxxxxxxxxx
   https://github.com/xxxxxxxxxx/
   https://github.com/xxxxxxxxxx/issues
   https://github.com/xxxxxxxxxx/issues/
   All of the above should retrieve same results.(all are converted to https://github.com/xxxxxxxxxx/issues)
5. After this, the issues are retrieved page wise by appending "?page=" + i + "&q=is%3Aissue+is%3Aopen" to the URL we got in previous step, where i is the ith page.
   Call is made for each page to GetItems function that will download JSON data as string using the URL we just formed and returns as a list the deserialized data in the JSON format  into object of Rootobject.cs (Which has same object mapping as JSON string) 
6. After this, we just iterate through the list, one object at a time, first checking if it is pull request or not( If it is a pull request then we leave the current iteration and just continue with the next iteration). and by checking the status tag we know whether the issue is open or not; similarly 
   by checking the difference of current time and created time we calculate the number of hours.
7. Thus all four parts of the question is solved and displayed in the screen in a table.
8. Given more time, I could work on the look and feel of the application. The program would have been more modular i.e I would have made different functions for each task, like displaying output.(currently I have done most of the work in the button_onclick function) 
   More over, there is no separate Business logic class in the program.
   I did every thing in the code behind .cs file
 

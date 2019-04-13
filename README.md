# awh-clockwork
Final solution for the AWH Clockwork interview exercise.

### How to run the application ###
* Clone this repository
* Open the solution
* If you encounter missing reference errors, kindly run "Update-Package -reinstall" command in Package Manager Console.
* Run "Update-Database" command and ensure that Clockwork.API is the selected default project in Package Manager Console.
* Run Clockwork.API
* Update value of "APIUrl" key in Web.config of Clockwork.Web. This is the api url (Clockwork.API).
* Run Clockwork.Web

### TODOs ###
* Searchable timezone dropdown by using plugins such as bootstrap-select or select2.
* Use jquery datatables for time list.
* Implement bundle & minification in Layout css and js.

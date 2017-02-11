# Virtual Address Book

#### A website to store contact details

#### By Minh Phuong

## Description

A website to store contact information.

## Setup/Installation Requirements

* Clone From GitHub
* Open a cmd program
* Navigate to downloaded folder
* Type in cmd window "dnx kestrel"
* Enter this url in desired browser http://localhost:5004

## Specification
* The program will take user input and make into a list in contacts.cshtml
  * Input Example: Name, Address, Phone Number, Email
  * Output Example: List name as clickable link in contacts.cshtml

* When the user click on each name on the list, they will be directed to the individual page created for that contact
  * Input Example: Click on Name
  * Output Example: All contact details are shown on the individual page

* When the user click on clear single entry, the entry will be deleted and they will be directed to a cleared page
  * Input Example: Click on Clear this entry
  * Output Example: Entry has been cleared

* When the user click on clear entire, the address book will be deleted
  * Input Example: Click on Clear All Entries
  * Output Example: Your Address Book is empty

* When the user enter a search name, a clickable link with matched name will be displayed in the list result
  * Input Example: Searchterm
  * Output Example: Your search result is "Searchterm"

## Known Bugs

No known bugs

## Support and contact details

Contact me at mphuong@kent.edu.

## Technologies Used

HTML, CSS, Bootstrap, C#, Nancy, Razor.

### License

Copyright (c) 2017 *Minh Phuong*

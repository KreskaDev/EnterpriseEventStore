Abstract

Aftert an some investigation, i realized that, there is already an solution for event store for mssql.
The name if the repository do not allign with overall concept.
To be fair, i do not even what it even should look like. 
We got time to deal with it.

Original idea was to create an framework, to persist state change, not state itself.

Event flow library cover all the features that i want to include into this repository.
It means, that we got an infrastructure to create an example.

First goal is to create, an example how to use an event store to determine an application state.



The application

Application should cover following feaures:
There is an main legal persona that handles all transactions.
There are multiple personas that do not have an sell channel, and it is an saless channel.

All creators need to be get throught an approval workflow to be included into the platform.
An creator, can propose an product that he can sell.
Product need to be processed with aceptance creteria.
All of the peapole, accepts product.
Someone reject an product.


Is creator an checked creator.


Order need to be papid
Order need to be delivered.


The workflow

Make an event store database
Make an shop commands an event real
Make saga to include all persons that need to be present to allow ths product to appear in application
make sagas that encapsulate the delivery logic



When all application features is implemented correctly, make own enterprise event store.
For now on this library is enought to handle most cases.



TODO:
New Creator
Propose new Product
Accept product
Order Product






Days
10/100
#Release Notes

##Web WebInterface 2.5.0.1
###New Features
* Option to allow authentification without MD5 content hash

##Web WebInterface 2.2.0.5
###New Features
* Bridge to import framework: uploading import files to import profile directory

##Web WebInterface 2.2.0.4
###New Features
* Added OData endpoint for shipment items
* Added OData action to add a shipment to an order and to set it as shipped
###Improvements
* OData actions should return SingleResult<TEntity> (instead of entity instance) to let expand option be recognized

##Web WebInterface 2.2.0.3
###New Features
* Added OData endpoint for payment method
* #727 Option to deactivate TimestampOlderThanLastRequest validation
* #731 Allow deletion and inserting of product category and manufacturer assignments
###Improvements
* Using header timestamp as last user request date rather than WebInterface server date

##Web WebInterface 2.2.0.2
###Improvements
* WebWebInterfaceAuthenticate attribute can be applied on methods too
* Product image upload requires manage catalog permission

##Web WebInterface 2.2.0.1
###New Features
* #652 Support for file upload and multipart mime

##Web WebInterface 1.32
###New Features
* #618 Add endpoint for quantity units

##Web WebInterface 1.31
###Bugfixes
* WebWebInterfaceController requires more permission checks

##Web WebInterface 1.23
###New Features
* #431 Add support for localized properties

##Web WebInterface 1.22
###New Features
* #393 Implement OData actions for simpler working with product attributes -> added ProductsController.ManageAttributes and ProductsController.CreateAttributeCombinations

##Web WebInterface 1.21
###Improvements
* #384 Inserting sluged recources like products require an URL record
###Bugfixes
* PUT implementation was incomplete
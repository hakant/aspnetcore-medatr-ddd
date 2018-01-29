# aspnetcore-medatr-ddd

* This is an aspnet core web api that contains a few ideas
  * Separating the host framework (webapi) and business domains into separate projects (assemblies)
  * Vertically slicing the business logic instead of using horizontal layers - achieving this with MediatR
  * Encapsulating each request, response and handler into their own single scenario
  * Separating the application into multiple domains (DDD) each containing their own 
    * scenarios (request, response and handlers)
    * subset of the data context (only the parts that are relevant to the domain)
    * entities - even only the properties of entites that are interesting for the domain

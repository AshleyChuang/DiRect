# DiReCT (Disaster Record Capture Tool)

Today, disaster historical records are typically written in natural language text together with tables, graphs, etc. In their current form, disaster records have two shortcomings. Data and information may be inconsistent and incomplete, and such defects take time and effort to uncover.

DiReCT (Disaster Record Capture Tool) is using by trained professionals to capture and record observational data during disasters and emergencies and can produce records in standard formats readable by search, analysis, simulation and visualization tools. Also, carry out data quality assurance and real-time quality control to improve the completeness and consistency of data on disasters and emergencies.

# Data structure

## ObservationRecord class & subclasses 

These data structures are designing to store the observation record. 

The ObservationRecord is an abstract class which contains essential properties for all types disaster records, also there are
several different disaster subclasses inherited this abstract class and implement their own properties.


## StandardOperatingProcedures class & subclasses

Experts will follow the standard operating procedures to record the disaster. 

The SOP class is an abstract class which contains the essential properties for all types disaster records, also there are
several subclasses inherited this abstract class and implement their own properties.




![](https://github.com/OpenISDM/DiReCT/blob/master/DiReCT/ClassDiagram1.png)

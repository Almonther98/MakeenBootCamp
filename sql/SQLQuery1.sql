/*create table airlines(airline_id int primary key , 
						AirlinName varchar(50),
						contactnumber int, 
						contactemail varchar(50), p
						ersonrepresentinairport varchar(50));

create table flights(flghits_id int primary key ,
					departureCity varchar(50), 
					gateNumber int , 
					fliteStatuse varchar(50), 
					ArrivelTime date , 
					departureTime date, 
					airline_id  int FOREIGN key   REFERENCES  airlines(airline_id) );

create table passengers ( Passenger_id int primary key ,
							fName varchar(50), 
							lName varchar(50), 
							dateOfBirth  date , 
							gender varchar(50), 
							nationality varchar(50) , 
							passportNumber int ,
							ContactPone int ,
							contactEmail varchar(50) );

create table baggage(baggage_id int primary key , 
					trakingNumber int , 
					baggage_weight float , 
					Passenger_id int FOREIGN key   REFERENCES  passengers (Passenger_id) );

create table termnal(termnal_id int primary key ,
					 termnal_name varchar(50),
					 capacity float ,
					 termal_location varchar(50));

create table gate(gate_id int primary key ,
				  gate_number int ,
				  gate_status varchar(50),
				  termnal_id int FOREIGN key   REFERENCES termnal(termnal_id));
			create table securtyCheckpoint(securtyCheckpoint_id int primary key , 
										   passengerCpacty float ,
										   securtyCheckpoint_location varchar(50),
										   termnal_id int FOREIGN key   REFERENCES termnal(termnal_id));
create table officer(officer_id int primary key ,
					 fName varchar(50),
					 lName varchar(50),
					 position varchar(50),
					 department varchar(50),
					 contactEmail varchar(50),
					 contactNumber varchar(50),
					 securtyCheckpoint_id int FOREIGN key   REFERENCES securtyCheckpoint(securtyCheckpoint_id) );

create table securtyCheckpoint(securtyCheckpoint_id int primary key ,
							   passengerCpacty varchar(50),
							   securtyCheckpoint_location varchar(50),
							   termnal_id int FOREIGN key   REFERENCES termnal(termnal_id));

alter table passengers add flghits_id int FOREIGN key   REFERENCES flights(flghits_id)

alter table passengers add termnal_id int FOREIGN key   REFERENCES termnal(termnal_id)

alter table securtyCheckpoint add airline_id int FOREIGN key   REFERENCES airlines(airline_id)
*/

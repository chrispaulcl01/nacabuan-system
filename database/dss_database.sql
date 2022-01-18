DROP DATABASE IF EXISTS dss_database;

CREATE DATABASE dss_database;

CREATE TABLE    dss_database.add_animal (
	id					INT(8) NOT NULL AUTO_INCREMENT,
	pet_id					VARCHAR(55) NOT NULL,
	owners_name				VARCHAR(55) NOT NULL,
	patient_name				VARCHAR(55) NOT NULL,
    contact_no				VARCHAR(55) NOT NULL,
	gender					VARCHAR(55) NOT NULL,
	birthday				VARCHAR(55) NOT NULL,
	age					    VARCHAR(55) NOT NULL,
	animal_species				VARCHAR(55) NOT NULL,
	animal_breed				VARCHAR(55) NOT NULL,
	date					DATETIME,
    primary_date            TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY(id)
    
);

CREATE TABLE dss_database.saved_patient (
	id						INT(8) NOT NULL AUTO_INCREMENT,
	pet_id					VARCHAR(55) NOT NULL,
	owners_name				VARCHAR(55) NOT NULL,
	patient_name			VARCHAR(55) NOT NULL,
	age						VARCHAR(55) NOT NULL,
	gender					VARCHAR(55) NOT NULL,
	birthday				VARCHAR(55) NOT NULL,
	animal_species			VARCHAR(55) NOT NULL,
	animal_breed			VARCHAR(55) NOT NULL,
	contact_no				VARCHAR(55) NOT NULL,
    temperature             DOUBLE NOT NULL,
	last_vaccine_date       DATETIME,
	exsist_condition        VARCHAR(55) NOT NULL,
    allergies               VARCHAR(55) NOT NULL,
    type_vaccine            VARCHAR(55) NOT NULL,
    weight                  DOUBLE NOT NULL,
    question                VARCHAR(55) NOT NULL,
    stool					VARCHAR(55) NOT NULL,
    behav_att				VARCHAR(55) NOT NULL,	
    appetite				VARCHAR(55) NOT NULL,
    drink					VARCHAR(55) NOT NULL,
    diagnosis				VARCHAR(100) NOT NULL,
    primary_date            TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY(id)
    
);

CREATE TABLE dss_database.save_RX (
	id						INT(8) NOT NULL AUTO_INCREMENT,
	pet_id					VARCHAR(55) NOT NULL,
	owners_name				VARCHAR(55) NOT NULL,
	patient_name			VARCHAR(55) NOT NULL,
	TimeDate_rx			    TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	prescription			VARCHAR(55) NOT NULL,
	PRIMARY KEY(id)
);

CREATE TABLE dss_database.reciept (
	id						INT(8) NOT NULL AUTO_INCREMENT,
	pet_id					VARCHAR(55) NOT NULL,
	owners_name				VARCHAR(55) NOT NULL,
    patient_name			VARCHAR(55) NOT NULL,
    total_fee               DOUBLE NOT NULL,
    amount_pay              DOUBLE NOT NULL,
    rchange                 DOUBLE DEFAULT NULL,
	TimeDate_rx			    TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY(id)
);

CREATE TABLE dss_database.add_notice(
    id                      INT(8) NOT NULL AUTO_INCREMENT,
    pet_id                  VARCHAR(55) NOT NULL,
    notice                  VARCHAR(55) NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE dss_database.add_booking (
	id					INT(8) NOT NULL AUTO_INCREMENT,
	name					VARCHAR(55) NOT NULL,
	pet_type				VARCHAR(55) NOT NULL,
	contacts				VARCHAR(55) NOT NULL,
	schedule				VARCHAR(55) NOT NULL,
	date					TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY(id)
);

CREATE TABLE dss_database.diagnosis (
	id					INT(8) NOT NULL AUTO_INCREMENT,
	pet_id					VARCHAR(55) NOT NULL,
	diagnosis				VARCHAR(300) DEFAULT NULL,
	PRIMARY KEY(id)
);

CREATE TABLE dss_database.medication (
	id					INT(8) NOT NULL AUTO_INCREMENT,
	pet_id					VARCHAR(55) NOT NULL,
	medication				VARCHAR(300) DEFAULT NULL,
	PRIMARY KEY(id)
);

CREATE TABLE dss_database.user (
	id					INT(8) NOT NULL AUTO_INCREMENT,
	username					VARCHAR(250),
	password				VARCHAR(250)	,
	PRIMARY KEY(id)
);

CREATE TABLE dss_database.symptoms (
    id                  INT(8) NOT NULL AUTO_INCREMENT,
    pet_id				VARCHAR(55) NOT NULL,
    stool				VARCHAR(55) NOT NULL,
    behav_att			VARCHAR(55) NOT NULL,	
    appetite			VARCHAR(55) NOT NULL,
    drink				VARCHAR(55) NOT NULL,
    notice				VARCHAR(55) NOT NULL,
    diagnosis			VARCHAR(100) NOT NULL,
    PRIMARY KEY(id)
);
INSERT INTO dss_database.user(
    username, 
    `password`)
     VALUES(
        "admin",
        MD5("admin")
);

CREATE TABLE dss_database.preg_cesarian (
    id                  INT(8) NOT NULL AUTO_INCREMENT,
    pet_id         VARCHAR(10) NOT NULL,
    owners_name					VARCHAR(55) NOT NULL,
    phone_num			    VARCHAR (55) NOT NULL,
    address					VARCHAR(55)NOT NULL,
    pet_name					VARCHAR(55) NOT NULL,
    pet_age					INT(10) NOT NULL,
    pet_gender					VARCHAR(55) NOT NULL,
    pet_bday					Date,
    pet_species					VARCHAR(55) NOT NULL,
    pet_breed					VARCHAR(55) NOT NULL,
    pet_weight					VARCHAR(55) NOT NULL,
    pet_allergies					VARCHAR(55) NOT NULL,
    pet_existdesease					VARCHAR(55) NOT NULL,
    operation					VARCHAR(55) NOT NULL,
    op_date				DATE,
    op_time             TIME,
    PRIMARY KEY(id)
);

CREATE TABLE dss_database.earoperation (
    id                  INT(8) NOT NULL AUTO_INCREMENT,
    pet_id         VARCHAR(10) NOT NULL,
    owners_name					VARCHAR(55) NOT NULL,
    phone_num			    VARCHAR (55) NOT NULL,
    address					VARCHAR(55)NOT NULL,
    pet_name					VARCHAR(55) NOT NULL,
    pet_age					INT(10) NOT NULL,
    pet_gender					VARCHAR(55) NOT NULL,
    pet_bday					Date,
    pet_species					VARCHAR(55) NOT NULL,
    pet_breed					VARCHAR(55) NOT NULL,
    pet_weight					VARCHAR(55) NOT NULL,
    pet_allergies					VARCHAR(55) NOT NULL,
    pet_currmed					VARCHAR(55) NOT NULL,
    operation					VARCHAR(55) NOT NULL,
    op_date				DATE,
    op_time             TIME,
    PRIMARY KEY(id)
);

CREATE TABLE dss_database.eyeoperation (
    id                  INT(8) NOT NULL AUTO_INCREMENT,
    pet_id         VARCHAR(10) NOT NULL,
    owners_name					VARCHAR(55) NOT NULL,
    phone_num			    VARCHAR (55) NOT NULL,
    address					VARCHAR(55)NOT NULL,
    pet_name					VARCHAR(55) NOT NULL,
    pet_age					INT(10) NOT NULL,
    pet_gender					VARCHAR(55) NOT NULL,
    pet_bday					Date,
    pet_species					VARCHAR(55) NOT NULL,
    pet_breed					VARCHAR(55) NOT NULL,
    pet_weight					VARCHAR(55) NOT NULL,
    pet_allergies					VARCHAR(55) NOT NULL,
    pet_currmed					VARCHAR(55) NOT NULL,
    operation					VARCHAR(55) NOT NULL,
    op_date				DATE,
    op_time             TIME,
    PRIMARY KEY(id)
);

CREATE TABLE dss_database.skintreatmen (
    id                  INT(8) NOT NULL AUTO_INCREMENT,
    pet_id         VARCHAR(10) NOT NULL,
    owners_name					VARCHAR(55) NOT NULL,
    phone_num			    VARCHAR (55) NOT NULL,
    address					VARCHAR(55)NOT NULL,
    pet_name					VARCHAR(55) NOT NULL,
    pet_age					INT(10) NOT NULL,
    pet_gender					VARCHAR(55) NOT NULL,
    pet_bday					Date,
    pet_species					VARCHAR(55) NOT NULL,
    pet_breed					VARCHAR(55) NOT NULL,
    pet_weight					VARCHAR(55) NOT NULL,
    pet_skinallergies					VARCHAR(55) NOT NULL,
    pet_existdisease					VARCHAR(55) NOT NULL,
    operation					VARCHAR(55) NOT NULL,
    op_date				DATE,
    op_time             TIME,
    PRIMARY KEY(id)
);

CREATE TABLE dss_database.CDTest (
    id                  INT(8) NOT NULL AUTO_INCREMENT,
    pet_id         VARCHAR(10) NOT NULL,
    owners_name					VARCHAR(55) NOT NULL,
    phone_num			    VARCHAR (55) NOT NULL,
    address					VARCHAR(55)NOT NULL,
    pet_name					VARCHAR(55) NOT NULL,
    pet_age					INT(10) NOT NULL,
    pet_gender					VARCHAR(55) NOT NULL,
    pet_bday					Date,
    pet_species					VARCHAR(55) NOT NULL,
    pet_breed					VARCHAR(55) NOT NULL,
    pet_weight					VARCHAR(55) NOT NULL,
    pet_allergies					VARCHAR(55) NOT NULL,
    pet_existdisease					VARCHAR(55) NOT NULL,
    pet_testkit					VARCHAR(55) NOT NULL,
    operation					VARCHAR(55) NOT NULL,
    op_date				DATE,
    op_time             TIME,
    PRIMARY KEY(id)
);

CREATE TABLE dss_database.CPTest (
    id                  INT(8) NOT NULL AUTO_INCREMENT,
    pet_id         VARCHAR(10) NOT NULL,
    owners_name					VARCHAR(55) NOT NULL,
    phone_num			    VARCHAR (55) NOT NULL,
    address					VARCHAR(55)NOT NULL,
    pet_name					VARCHAR(55) NOT NULL,
    pet_age					INT(10) NOT NULL,
    pet_gender					VARCHAR(55) NOT NULL,
    pet_bday					Date,
    pet_species					VARCHAR(55) NOT NULL,
    pet_breed					VARCHAR(55) NOT NULL,
    pet_weight					VARCHAR(55) NOT NULL,
    pet_allergies					VARCHAR(55) NOT NULL,
    pet_existdisease					VARCHAR(55) NOT NULL,
    pet_testkit					VARCHAR(55) NOT NULL,
    operation					VARCHAR(55) NOT NULL,
    op_date				DATE,
    op_time             TIME,
    PRIMARY KEY(id)
);

CREATE TABLE dss_database.vaccination (
    id                  INT(8) NOT NULL AUTO_INCREMENT,
    pet_id       VARCHAR(10) NOT NULL,
    owners_name					VARCHAR(55) NOT NULL,
    address					VARCHAR(55)NOT NULL,
    pet_age					INT(10) NOT NULL,
    pet_gender					VARCHAR(55) NOT NULL,
    pet_bday					VARCHAR(55) NOT NULL,
    pet_species					VARCHAR(55) NOT NULL,
    pet_breed					VARCHAR(55) NOT NULL,
    pet_weight					VARCHAR(55) NOT NULL,
    pet_allergies					VARCHAR(55) NOT NULL,
    pet_currentmed					VARCHAR(55) NOT NULL,
    pet_question					VARCHAR(55) NOT NULL,
    sched_date					VARCHAR(55) NOT NULL,
    type_vaccine					VARCHAR(55) NOT NULL,
    dosage					VARCHAR(55) NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE dss_database.mammarry (
    id                  INT(8) NOT NULL AUTO_INCREMENT,
    pet_id       VARCHAR(10) NOT NULL,
    owners_name					VARCHAR(55) NOT NULL,
    phone_num			    VARCHAR (55) NOT NULL,
    address					VARCHAR(55)NOT NULL,
    pet_name                VARCHAR(55) NOT NULL,
    pet_age					INT(10) NOT NULL,
    pet_gender					VARCHAR(55) NOT NULL,
    pet_bday					VARCHAR(55) NOT NULL,
    pet_species					VARCHAR(55) NOT NULL,
    pet_breed					VARCHAR(55) NOT NULL,
    pet_weight					VARCHAR(55) NOT NULL,
    pet_allergies					VARCHAR(55) NOT NULL,
    pet_existdisease					VARCHAR(55) NOT NULL,
    typevax					VARCHAR(55) NOT NULL,
    vaxdate                 DATE,
    PRIMARY KEY(id)
);

CREATE TABLE dss_database.bloodparasite (
    id                  INT(8) NOT NULL AUTO_INCREMENT,
    pet_id       VARCHAR(10) NOT NULL,
    owners_name					VARCHAR(55) NOT NULL,
    phone_num			    VARCHAR (55) NOT NULL,
    address					VARCHAR(55)NOT NULL,
    pet_name                VARCHAR(55) NOT NULL,
    pet_age					INT(10) NOT NULL,
    pet_gender					VARCHAR(55) NOT NULL,
    pet_bday					VARCHAR(55) NOT NULL,
    pet_species					VARCHAR(55) NOT NULL,
    pet_breed					VARCHAR(55) NOT NULL,
    pet_weight					VARCHAR(55) NOT NULL,
    pet_allergies					VARCHAR(55) NOT NULL,
    pet_existdisease					VARCHAR(55) NOT NULL,
    typevax					VARCHAR(55) NOT NULL,
    vaxdate                 DATE,
    PRIMARY KEY(id)
);

CREATE TABLE dss_database.checkup (
    id                  INT(8) NOT NULL AUTO_INCREMENT,
    pet_id         VARCHAR(10) NOT NULL,
    owners_name					VARCHAR(55) NOT NULL,
    address					VARCHAR(55)NOT NULL,
    pet_age					INT(10) NOT NULL,
    pet_gender					VARCHAR(55) NOT NULL,
    pet_bday					VARCHAR(55) NOT NULL,
    pet_species					VARCHAR(55) NOT NULL,
    pet_breed					VARCHAR(55) NOT NULL,
    PRIMARY KEY(id)
);


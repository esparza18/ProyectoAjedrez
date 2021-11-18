create database CLUBAJEDREZ;
use CLUBAJEDREZ;

CREATE TABLE Participantes (
    id varchar(20) primary key,
    nombre VARCHAR(50) NOT NULL,
    direccion VARCHAR(50) NOT NULL,
    telefono VARCHAR(50) NOT NULL,
    campeonato VARCHAR(50) NOT NULL,
    ocupacion VARCHAR(50) NOT NULL
);

CREATE TABLE Pais (
    id varchar(20) primary key,
    nombre VARCHAR(50) NOT NULL,
    num_club VARCHAR(50) NOT NULL
);

CREATE TABLE Partidas (
    id varchar(20) PRIMARY KEY,
    cod_p VARCHAR(50) NOT NULL,
    jornada VARCHAR(50) NOT NULL
);

CREATE TABLE Movimientos (
    id varchar(20) primary key,
    jugada VARCHAR(50) NOT NULL,
    comentario VARCHAR(50) NOT NULL,
    movimiento VARCHAR(50) NOT NULL
);

CREATE TABLE Hoteles (
    id varchar(20) primary key,
    nombre VARCHAR(50) NOT NULL,
    direccion VARCHAR(50) NOT NULL,
    telefono VARCHAR(50) NOT NULL 
);

CREATE TABLE SALA (
    entradas VARCHAR(50) primary key,
    capacidad VARCHAR(50) NOT NULL,
    medios VARCHAR(50) NOT NULL
);
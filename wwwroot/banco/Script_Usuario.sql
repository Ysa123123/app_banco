create database dbBancoApp4;
use dbBancoApp4;

create table usuario(
idUsu int primary key auto_increment,
nomeUsu varchar(50) not null,
cargo varchar(30) not null,
dataNasc datetime
);
create database GymUPC
go
use GymUPC
go

create table Cliente (
IDCliente int Identity(1,1),IDRS varchar(max), Usuario varchar(20), Pass varchar(20), Nombre varchar(30), Apellido varchar(30), DNI varchar(8), Direccion varchar(30), Telefono varchar(30),Imagen varbinary(max)
)
go
insert into Cliente(IDRS,Usuario,Pass,Nombre,Apellido,DNI,Direccion,Telefono,Imagen)values(null,'a','a','Nai','Añiugam','77778888','Villa Ian','1234',null)

create table Asociado (
IDAsociado int Identity(1,1), Usuario varchar(20), Pass varchar(20), Nombre varchar(30), Apellido varchar(30), DNI varchar(8), Direccion varchar(30), Telefono varchar(30)
) 

insert into Asociado values ('AS001','1234','Don Lusho','Haciendo solo Arqui','00000000','Haciendo Trabajo de Funda','1234');
insert into Asociado values ('AS002','1234','Luis','Veliz','12312323','Y el trabajo de Web?','1234');
insert into Asociado values ('AS003','1234','Victor','BuscandoGrupo','12312312','Villa Ian','1234');

create table Administrador (
IDAdministrador int Identity(1,1), Usuario varchar(20), Pass varchar(20), Nombre varchar(30), Apellido varchar(30), DNI varchar(8), Direccion varchar(30), Telefono varchar(30)
)

insert into Administrador values ('A001','1234','Ian','Maguiña','7777777','Villa Ian','1234');

insert into Administrador values ('b','b','Ian','Maguiña','7777777','Villa Ian','1234');

create table Establecimiento (
IDEstablecimiento int Identity(1,1), Latitud varchar(30), Longitud varchar(30), Nombre varchar(30), Descripcion varchar(80)
)

select * from Establecimiento
insert into Establecimiento values ('-12.0928595','-77.0463300','RichiGym','El Gim de Richi')
insert into Establecimiento values ('-12.1928590','-77.2463300','Brancagimnasio','Debajo del Brancamar!!')
insert into Establecimiento values ('-12.0828590','-77.2463300','El Gimnasio de Don Ian','El 1er Gimnasio de Don Ian');

create table Categoria (
IDCategoria int Identity(1,1), Nombre varchar(25), Descripcion varchar(80)
)

insert into Categoria values ('Yoga','Disciplina física y mental asociada a la meditación');
insert into Categoria values ('Abdominales','Conjunto de ejercicios especializados para definición del abdomen');
insert into Categoria values ('Fuerza','Clases especializadas en incrementar la resistencia y capacidad de carga');



create table CategoriaHorario(
IDCategoriaHorario int Identity(1,1), IDCategoria int, Dia varchar(10), HoraInicio varchar(10), IDEstablecimiento int
)

insert into CategoriaHorario values (1,'Lunes','10:00',1)
insert into CategoriaHorario values (1,'Lunes','11:00',1)
insert into CategoriaHorario values (1,'Martes','10:00',1)


create table Planes (
IDPlan int Identity(1,1), IDEstablecimiento int,Nombre varchar(15), Descripcion varchar(100), Precio float, Oferta char
)

insert into Planes values (1,'Body Work','Clases orientadas al desarrollo y esculpimiento del cuerpo',100,'N')

create table CategoriaPlan (
IDCategoriaPlan int Identity(1,1), IDCategoria int, IDPlan int
)

insert into CategoriaPlan values (1,1)

create table ClientePlan (
IDClientePlan int Identity(1,1), IDCliente int, IDPlan int, Mes varchar(10), Dia varchar(10), Año int, Autorizado char
)

insert into ClientePlan values (1,1,'Junio','Lunes',2016,'N')


alter table Cliente          add constraint  PK_Cliente          primary key(IDCliente)
alter table Asociado         add constraint  PK_Asociado         primary key(IDAsociado)
alter table Administrador    add constraint  PK_Administrador    primary key(IDAdministrador)
alter table Categoria        add constraint  PK_Categoria        primary key(IDCategoria)
alter table CategoriaHorario add constraint  PK_CategoriaHorario primary key(IDCategoriaHorario)
alter table Establecimiento  add constraint  PK_Establecimiento  primary key(IDEstablecimiento)
alter table Planes           add constraint  PK_Planes           primary key(IDPlan)
alter table ClientePlan      add constraint  PK_ClientePlan      primary key(IDClientePlan)
alter table CategoriaPlan    add constraint  PK_CategoriaPlan    primary key(IDCategoriaPlan)

alter table CategoriaHorario        add constraint FK_CategoriaHorario_Establecimiento  foreign key(IDEstablecimiento) references Establecimiento(IDEstablecimiento)
alter table CategoriaHorario        add constraint FK_CategoriaHorario_Categoria        foreign key(IDCategoria)       references Categoria(IDCategoria)
alter table Planes                  add constraint FK_Planes_Establecimiento            foreign key(IDEstablecimiento) references Establecimiento(IDEstablecimiento)
alter table ClientePlan             add constraint FK_ClientePlan_Cliente               foreign key(IDCliente)         references Cliente(IDCliente)
alter table ClientePlan             add constraint FK_ClientePlan_Plan                  foreign key(IDPlan)            references Planes(IDPlan)
alter table CategoriaPlan           add constraint FK_CategoriaPlan_Plan                foreign key(IDPlan)            references Planes(IDPlan)
alter table CategoriaPlan           add constraint FK_CategoriaPlan_Categoria           foreign key(IDCategoria)       references Categoria(IDCategoria)
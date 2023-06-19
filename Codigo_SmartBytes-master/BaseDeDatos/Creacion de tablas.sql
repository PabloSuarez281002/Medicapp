create table Usuario(
	CI char(9) primary key not null,
    check (char_length(CI)=8),
    PrimerNombre varchar(15) not null,
    PrimerApellido varchar(15) not null,
    SegundoApellido varchar(15) not null,
    Sexo enum('Masculino', 'Femenino') not null,
    Telefono varchar(15) not null,
    Calle varchar(30) not null,
    Esquina varchar(30) not null,
	NumeroPuerta varchar(15) not null,
    FechaNacimiento date not null,
    Mail varchar(80) not null unique key
);

create table Administrador(
	CIAdmin char(9) not null,
    Contrasena varchar(30) not null,
    check (char_length(Contrasena)>=8),
    foreign key(CIAdmin) references Usuario(CI)
);

create table Medico(
	CIMedico char(9) not null,
    Contrasena varchar(30) not null,
    check (char_length(Contrasena)>=8),
    foreign key(CIMedico) references Usuario(CI),
    Especialidad varchar(30) not null
);

create table Paciente(
	CIPaciente char(9) not null,
    Contrasena varchar(30) not null,
    check (char_length(Contrasena)>=8),
    foreign key(CIPaciente) references Usuario(CI)
);

create table Sintoma(
	CodigoSintoma int(20) auto_increment primary key not null,
    NombreSintoma varchar(60) not null
);

create table Patologia(
	CodigoPatologia int(20) auto_increment primary key not null,
    Especialista varchar(30) not null,
    Gravedad int(5),
    NombrePatologia varchar(100) not null,
    check (Gravedad<=5)
);

create table Asociado(
    CodigoPatologia int(20) not null,
	CodigoSintoma int(20) not null,
    primary key(CodigoSintoma,CodigoPatologia),
    foreign key(CodigoPatologia) references Patologia(CodigoPatologia),
    foreign key(CodigoSintoma) references Sintoma(CodigoSintoma)    
);

create table Diagnostico(
	CodigoDiagnostico int(20) auto_increment primary key not null,
    CodigoPatologiaPrimaria int(20) not null,
    CodigoPatologiaFinal int(20) ,
    Estado enum('Activo', 'Inactivo') not null ,
    FechaDiagnostico date not null
);

create table Tiene(
	CIPaciente char(9) not null,
    foreign key(CIPaciente) references Paciente(CIPaciente),
    CodigoSintoma int(20) not null,
    Fecha date not null
);

create table Recibe(
	CIPaciente char(9) not null,
    foreign key(CIPaciente) references Paciente(CIPaciente),
    CodigoDiagnostico int(20) not null,
    foreign key(CodigoDiagnostico) references Diagnostico(CodigoDiagnostico)
);

create table Chatea(
	CIMedico char(9) not null,
    foreign key(CIMedico) references Medico(CIMedico),
    CIPaciente char(9) not null,
    foreign key(CIPaciente) references Paciente(CIPaciente)
);

create table MensajeChat(
    CodigoMensaje int(20) auto_increment unique key not null,
	CiEmisor char(9) not null,
    foreign key(CiEmisor) references Usuario(Ci),
    ContenidoMensaje varchar(300) not null,
    FechaMensaje datetime not null,
    CodigoDiagnostico int(20) not null
);

create table Atiende(
	CodigoDiagnostico int(20) not null,
    foreign key(CodigoDiagnostico) references Diagnostico(CodigoDiagnostico),
	CIMedico char(9) not null,
    foreign key(CIMedico) references Medico(CIMedico)
);

create table Corresponde(
	CodigoDiagnostico int(20) not null,
	CodigoPatologia int(20) not null,
    foreign key(CodigoDiagnostico) references Diagnostico(CodigoDiagnostico),
    foreign key(CodigoPatologia) references Patologia(CodigoPatologia)
);

create table MedicoEnvia(
	codigoMensaje int(20) not null,
	CiMedico Char(9) not null,
    foreign key(codigoMensaje) references MensajeChat(codigoMensaje),
    foreign key(CiMedico) references Medico(CiMedico)
);

create table PacienteEnvia(
	codigoMensaje int(20) not null,
	CiPaciente Char(9) not null,
    foreign key(codigoMensaje) references MensajeChat(codigoMensaje),
    foreign key(CiPaciente) references Paciente(CiPaciente)
);

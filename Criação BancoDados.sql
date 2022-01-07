use ProjetoLogin

CREATE TABLE logins
(
	email varchar(50) not null,
	senha varchar(20) not null
)

select * from logins;

INSERT INTO logins(email, senha) VALUES ('murillojulio@gmail.com', '12345678');
INSERT INTO logins(email, senha) VALUES ('joana@gmail.com', '12345678');
INSERT INTO logins(email, senha) VALUES ('leandro@gmail.com', '12345678');
INSERT INTO logins(email, senha) VALUES ('marco@gmail.com', '12345678');
INSERT INTO logins(email, senha) VALUES ('lucas@gmail.com', '12345678');
INSERT INTO logins(email, senha) VALUES ('samuel@gmail.com', '12345678');
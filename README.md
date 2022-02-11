
# **PROJETO FINAL - PROTOCOLO BICICLETA COM RODINHAS**

### **SQUAD ITUBAÍNA:**

*Augusto de Paulo Santos:*

Analista de Desenvolvimento - Banco de Dados e Back-End


*Gustavo Silva Aguiar:*

Analista de Desenvolvimento - Prototipação e Front-End


*Nelson Gomes Ferreira Mendes Neto:*

Analista de Desenvolvimento - Front-End


*Taynã Souza Malaquias:*

Analista de Desenvolvimento - Back-End


*Willian da Silva Almeida:*

Analista de Desenvolvimento - Back-End e Devops

----------------------------------------------------------------------------------------------

#### **Configurações necessárias para execução do projeto:** 

• Criar o banco de dados utilizando o script fornecido em “Script de Criação de Tabelas”

• Povoar com o script “SQL de Testes”; 

• Acessar o banco MS SQL SERVER utilizando o localhost e autenticação Windows;

____________________________________________________________________________________________

### **Script de Criação de Tabelas:**


~~~SQL

CREATE DATABASE SISTEMA_FINANCEIRO 

USE SISTEMA_FINANCEIRO 

--SCRIPT DE CREATE 

  

CREATE TABLE CIDADES ( 

                CID_ID INT IDENTITY NOT NULL, 

                CID_NOME VARCHAR (50) NOT NULL, 

                CID_UF VARCHAR (2) NOT NULL, 

                CONSTRAINT CID_ID PRIMARY KEY (CID_ID) 

)  

CREATE TABLE EMPRESAS ( 

                EMP_ID INT IDENTITY NOT NULL, 

                EMP_RAZA VARCHAR (100) NOT NULL, 

                EMP_FANT VARCHAR (50), 

                EMP_CNPJ VARCHAR (14), 

                EMP_CPF VARCHAR(11), 

                EMP_LOGR VARCHAR (150) NOT NULL, 

                EMP_BAIR VARCHAR (150) NOT NULL, 

                EMP_COMP VARCHAR (200), 

                EMP_NUME VARCHAR (10), 

                EMP_CEP VARCHAR (10), 

                EMP_IE VARCHAR (25), 

                CID_ID INT, 

                CONSTRAINT EMP_ID PRIMARY KEY (EMP_ID) 

) 

  

CREATE TABLE ENDERECOS ( 

                END_ID INT IDENTITY NOT NULL, 

                END_NUME VARCHAR (10), 

                END_BAIR VARCHAR (150), 

                END_COMP VARCHAR (200), 

                END_CEP VARCHAR (10), 

                END_LOGR VARCHAR (150), 

                CID_ID INT, 

                CONSTRAINT END_ID PRIMARY KEY (END_ID) 

) 

  

CREATE TABLE FORNECEDORES ( 

                FOR_ID INT IDENTITY NOT NULL, 

                FOR_NOME VARCHAR (100) NOT NULL, 

                CNPJ_CPF VARCHAR (14), 

                END_ID INT, 

                CONSTRAINT FOR_ID PRIMARY KEY (FOR_ID) 

) 

  

CREATE TABLE PAGAR ( 

                PAG_ID INT IDENTITY NOT NULL, 

                EMP_ID INT NOT NULL, 

                FOR_ID INT NOT NULL, 

                PAG_NUME VARCHAR (30), 

                PAG_VALOR decimal (10, 2), 

                PAG_OBSE VARCHAR (150), 

                PAG_DATA DATETIME NOT NULL, 

                PAG_STAT CHAR (1) DEFAULT 'A', 

                CONSTRAINT PAG_ID PRIMARY KEY (PAG_ID) 

) 

  

CREATE TABLE CLIENTES ( 

                CLI_ID INT IDENTITY NOT NULL, 

                CLI_NOME VARCHAR (100) NOT NULL, 

                CPF_CNPJ VARCHAR (14), 

                END_ID INT, 

                CONSTRAINT CLI_ID PRIMARY KEY (CLI_ID) 

) 

  

CREATE TABLE RECEBER ( 

                REC_ID INT IDENTITY NOT NULL, 

                EMP_ID INT NOT NULL, 

                CLI_ID INT NOT NULL, 

                REC_NUME VARCHAR (30), 

                REC_VALOR decimal (10, 2), 

                REC_OBSE VARCHAR (150), 

                REC_DATA DATETIME NOT NULL, 

                REC_STAT CHAR (1) DEFAULT 'A', 

                CONSTRAINT REC_ID PRIMARY KEY (REC_ID) 

) 

  

ALTER TABLE ENDERECOS ADD CONSTRAINT CIDADES_ENDERECOS_fk 

FOREIGN KEY (CID_ID) 

REFERENCES CIDADES (CID_ID) 

ON DELETE NO ACTION 

ON UPDATE NO ACTION 

  

ALTER TABLE EMPRESAS ADD CONSTRAINT CIDADES_EMPRESAS_fk 

FOREIGN KEY (CID_ID) 

REFERENCES CIDADES (CID_ID) 

ON DELETE NO ACTION 

ON UPDATE NO ACTION 

 

ALTER TABLE PAGAR ADD CONSTRAINT EMPRESAS_PAGAR_fk 

FOREIGN KEY (EMP_ID) 

REFERENCES EMPRESAS (EMP_ID) 

ON DELETE NO ACTION 

ON UPDATE NO ACTION 

  

ALTER TABLE RECEBER ADD CONSTRAINT EMPRESAS_RECEBER_fk 

FOREIGN KEY (EMP_ID) 

REFERENCES EMPRESAS (EMP_ID) 

ON DELETE NO ACTION 

ON UPDATE NO ACTION 

  

ALTER TABLE CLIENTES ADD CONSTRAINT ENDERECOS_CLIENTES_fk 

FOREIGN KEY (END_ID) 

REFERENCES ENDERECOS (END_ID) 

ON DELETE NO ACTION 

ON UPDATE NO ACTION 

  

ALTER TABLE FORNECEDORES ADD CONSTRAINT ENDERECOS_FORNECEDORES_fk 

FOREIGN KEY (END_ID) 

REFERENCES ENDERECOS (END_ID) 

ON DELETE NO ACTION 

ON UPDATE NO ACTION 

  

ALTER TABLE PAGAR ADD CONSTRAINT FORNECEDORES_PAGAR_fk 

FOREIGN KEY (FOR_ID) 

REFERENCES FORNECEDORES (FOR_ID) 

ON DELETE NO ACTION 

ON UPDATE NO ACTION 

  

ALTER TABLE RECEBER ADD CONSTRAINT CLIENTES_RECEBER_fk 

FOREIGN KEY (CLI_ID) 

REFERENCES CLIENTES (CLI_ID) 

ON DELETE NO ACTION 

ON UPDATE NO ACTION 
~~~

____________________________________________________________________________________________________

### **SQL de Testes**

~~~SQL

INSERT INTO CIDADES 

(CID_NOME, CID_UF) 

VALUES 

('Goiânia', 'GO'), 

('Goiânia', 'GO'), 

('Goiânia', 'GO'), 

('Goiânia', 'GO'), 

('Goiânia', 'GO'), 

('Goiânia', 'GO') 

  

**INSERT INTO EMPRESAS**

(EMP_RAZA, EMP_FANT, EMP_CNPJ, EMP_LOGR, EMP_BAIR, EMP_NUME, EMP_CEP, CID_ID) 

VALUES 

('Siagri Sistemas de Gestao Ltda', 'Siagri Sistemas', '02435301000416', 'Av Caiapo','Santa Genoveva', '1528', '74.672-400', 1) 

  

  

**INSERT INTO ENDERECOS**

(END_NUME, END_BAIR, END_COMP, END_CEP, END_LOGR, CID_ID) 

VALUES 

('321', 'Negrao de Lima', '', '74650050', 'Rua Dona Darcy', 2), 

('01', 'Jardim dos Girassois', 'Qd 02 lt 23', '74971740', 'Rua 13', 3), 

('1', 'Jardim Guanabara', 'QD 19 LT 25', '74675050', 'Rua Araguari', 4), 

('7567', 'PANORAMA PARQUE', 'AP102 BL08', '74565006', 'RUA VITORIA REGIA', 5), 

('703', 'Vila Xavier', 'Qdr. 8 Lt. 17', '74550395', 'Av. Senador Jaime', 6) 

  

**INSERT INTO CLIENTES**

(CLI_NOME, CPF_CNPJ, END_ID) 

**VALUES** 

('Tayna Souza Malaquias', '75755726191', 1), 

('WILLIAN DA SILVA ALMEIDA', '06578453316', 2), 

('Nelson Gomes Ferreira Mendes Neto', '03476474135', 3) 

  

  

**INSERT INTO FORNECEDORES** 

(FOR_NOME, CNPJ_CPF, END_ID) 

**VALUES** 

('AUGUSTO DE PAULO SANTOS', '03888904102', 4), 

('Gustavo Silva Aguiar', '70608619124', 5) 

  

  

**INSERT INTO PAGAR** 

(EMP_ID, FOR_ID, PAG_NUME, PAG_VALOR, PAG_OBSE, PAG_DATA, PAG_STAT) 

VALUES 

(1, 1, '1', '400', 'Jardinagem', GETDATE (), 'A') 

  

  

INSERT INTO RECEBER 

(EMP_ID, CLI_ID, REC_NUME, REC_VALOR, REC_OBSE, REC_DATA, REC_STAT) 

VALUES 

(1, 1, '1', '250', 'Sistema', GETDATE (), 'A') 

~~~

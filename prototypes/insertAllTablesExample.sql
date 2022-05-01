
INSERT INTO [dbo].[usuario]
           ([id]
           ,[nome]
           ,[login]
           ,[senha]
           ,[role])
     VALUES
           ('6C816AE5-8669-A80E-73A7-01F487478338'
           ,'Raymond Chagas'
           ,'raymondchagas@ecossistemaanima.com.br'
           ,'INH39PLP4EF'
           ,'professor'),
		   ('9AA29D8A-6B7C-1FB1-E105-33E2E338C72E'
		   ,'Venus Matos'
		   ,'venusmatos@animaeducacao.com.br'
		   ,'RGH61SIK3LU'
		   ,'professor'),		   
		   ('4DD3B6B6-80DA-AA34-13B8-78750251267D'
           ,'Neville Caetano'
           ,'nevillecaetano@animaeducacao.com.br'
           ,'VGY61ENH5JK'
           ,'aluno'),
		   ('25FEBA7E-72FC-2179-5671-6A7C150B52DB'
           ,'Camilla Ferraz'
           ,'camillaferraz8307@ecosistemaanima.com.br'
           ,'RCD48KRM3EX'
           ,'aluno'),
		   ('EC38751C-D9B7-D5BC-86BB-A8C9F85B32C9'
           ,'Lucas Guedes'
           ,'lucasguedes@ecosistemaanima.com.br'
           ,'VOU16VSQ1LB'
           ,'aluno'),
		   ('2E5DE747-435A-E7EC-043C-229B9AD1E1B4'
           ,'Mariam da Cunha'
           ,'mariamdacunha@ecosistemaanima.com.br'
           ,'LEG82KIC4RC'
           ,'aluno')
GO

INSERT INTO [professor] (id,usuario_id)
VALUES
(  'EC44538B-C8D3-8842-D336-8C4E371B7B9E',  '6C816AE5-8669-A80E-73A7-01F487478338'),
(  '78E82B34-238C-AB34-A05E-53CC45D89754',  '9AA29D8A-6B7C-1FB1-E105-33E2E338C72E');


INSERT INTO [aluno] (id,usuario_id)
VALUES
(  'C2C93C0B-7A51-B67A-E7E7-BB8A35794681',  '4DD3B6B6-80DA-AA34-13B8-78750251267D'),
(  '8CA57761-76BD-4582-5D1B-666F4F1E62DF',  '25FEBA7E-72FC-2179-5671-6A7C150B52DB'),
(  '222680E5-DEE8-1348-2E9E-3C64976D63BE',  'EC38751C-D9B7-D5BC-86BB-A8C9F85B32C9'),
(  'F65097F9-7A2C-4876-C301-9F1A9798BE0C',  '2E5DE747-435A-E7EC-043C-229B9AD1E1B4')


INSERT INTO [prova] (id, nome,professor_id)
VALUES
(  '74571868-177D-B263-9965-700F2723BA15','ANALISE E DESENVOLVIMENTO DE SISTEMAS',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '38FA234D-1BC4-B469-E7B5-91ED1D385E94','BANCO DE DADOS',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  'ED7F7CEE-1514-8D34-CDC7-B351B03B7FB4','PROGRAMA��O',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  'E1BD8206-22F6-1ED0-5E2F-F4A24B3D48CD','TECNOLOGIAS APLICADAS A SISTEMAS DE INFORMA��O',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  'D91B156E-5B2E-AA63-A681-7E11D294AD4C','IDIOMAS',  '78E82B34-238C-AB34-A05E-53CC45D89754');


INSERT INTO [questao] (id,nome,enunciado,professor_id)
VALUES
(  '23A50283-E406-EC39-347D-6D68044B2617','T�cnica de Greylist','Procurando minimizar o n�mero de spams que uma empresa recebe, os administradores de rede resolveram implementar a t�cnica de greylist, que consiste em: ', 'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '3A6B406E-D83E-1E26-149E-1E19F268759A','Assinaturas Digitais','Em rela��o a assinaturas digitais, analise as afirmativas a seguir: I. Certificado categoria S2 � o certificado usado para assinatura digital, com tamanho m�nimo de 1024 bits, gerado por software e armazenado em um token. II. A verifica��o da assinatura digital de um documento eletr�nico � realizada atrav�s da chave p�blica do remetente do documento. III. O DSA, algoritmo usado para assinaturas digitais, possui uma variante que utiliza curvas el�pticas. Est� correto somente o que se afirma em:' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D','Norma ISO 27001','Uma empresa deseja ser certificada na implementa��o da norma ISO 27001. Para tal, ela deve seguir com rigor o que preconiza a norma, como por exemplo:' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2','Criptografia de Mensagens','Para criptografar mensagens de tamanho arbitr�rio, existem v�rios modos de opera��o especificando como a criptografia ser� aplicada. Um desses modos � fr�gil em termos de seguran�a, pois n�o oculta o padr�o de dados da mensagem original, mantendo-o na mensagem codificada. Esse modo de opera��o, menos seguro, � o:',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '2F936AE7-6B77-3ED8-CA4A-77945F856612','Representa��o Bin�ria','O n�mero inteiro �2 (menos dois) tem a seguinte representa��o em 16 bits, usando complemento a 2:' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  'C8D6156D-7476-5647-E7C3-8DE0D22591D6','Multiplica��o na base 16','O resultado da multiplica��o entre os inteiros 7F16 x 1216, ambos representados em complemento a 2 na base 16' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  'BC358B5E-6D78-34C6-0468-837ECA522878','UCP','O acesso a dados em registradores internos da Unidade Central de Processamento (UCP):' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C','Aloca��o de Mem�ria','A estrat�gia de aloca��o de mem�ria que busca o menor espa�o livre suficiente para satisfazer cada requisi��o denomina-se:' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '783A2951-A279-A225-AE16-95CBB34DC7FB','WSDL','Segundo Ian Sommerville, as arquiteturas orientadas a servi�os (SOA) s�o uma forma de desenvolvimento de sistemas distribu�dos em que os componentes de sistema s�o servi�os aut�nomos, executando em computadores geograficamente distribu�dos. Para que o acesso a esses servi�os ocorra, s�o utilizados alguns padr�es, dentre os quais est�o o SOAP, WSDL e WS-BPEL. A linguagem WSDL � baseada em XML e tem como fun��o especificar um servi�o (web service) considerando os seguintes aspectos:',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  'A84864C2-B45C-B065-BBB4-30869B3CD110','Mensagens de Log','Cristiano implementou o syslog nos servidores Linux que administra com o intuito de enviar todas as mensagens de log para um �nico servidor, que centralizar� todos os logs da rede. Cristiano n�o est� preocupado com a quantidade de mensagens de log  transmitidas entre os clientes e o servidor centralizador de log, pois:',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),

( 'CDAE91B1-D657-7999-3AF0-98EDC9AB354A','Adicci�n','�C�mo podemos traducir la palabra adicci�n en el texto?','78E82B34-238C-AB34-A05E-53CC45D89754'),
( '4D7AC40A-CFDE-15D4-FEA3-09B829B447C2','Horas','Qu� hora es? 1:45.','78E82B34-238C-AB34-A05E-53CC45D89754'),
( 'DFAADCBE-919B-6E57-B4BC-B7E73E8AC570','Presente de Indicativo','Elige la alternativa CORRECTA con la forma verbal adecuada de Presente de Indicativo','78E82B34-238C-AB34-A05E-53CC45D89754'),
( '4AFD3809-5274-DEA3-EC85-19498BBCC7F3','Participios','Se�ala la forma CORRECTA de los participios de los verbos: morir, decir, hacer, ver, poner, fre�r.','78E82B34-238C-AB34-A05E-53CC45D89754'),
( '7C41465A-AE84-DAB9-814C-412794FEE95E','Alternativa correcta','Lea y marque la alternativa CORRECTA.','78E82B34-238C-AB34-A05E-53CC45D89754'),
( '4D8EEA17-1CBC-8121-5B01-A788D254187C','Fecha','La fecha 06 / 02 / 1978 est� CORRECTAMENTE escrita.','78E82B34-238C-AB34-A05E-53CC45D89754'),
( '1234B457-DADD-1B2B-3EBC-5CFCDA392261','Conjugaci�n','Los verbos disfrutaba, comenzaron y hab�an puesto est�n conjugados en respectivamente','78E82B34-238C-AB34-A05E-53CC45D89754'),
( '562AA2CD-4A57-6E72-A760-BBC26C8C1A3D','Resposta correcta','Elige la respuesta adequada.','78E82B34-238C-AB34-A05E-53CC45D89754'),
( '136A733D-5C33-2935-C859-DDA9AD25B0BB','Alternativa sem erro','Elige la �nica alternativa que no presenta ERROR','78E82B34-238C-AB34-A05E-53CC45D89754'),
( '61240F89-7CE3-CC4A-8912-BFB6E5A785F8','S�laba t�nica','Las palabras son acentuadas diferentemente seg�n la s�laba t�nica. Marca la �nica alternativa que clasifica las palabras abajo CORRECTAMENTE: Dif�cil, F�rmula, Disposici�n, Mayor�a, as�','78E82B34-238C-AB34-A05E-53CC45D89754');

INSERT INTO [prova_questao] (id,prova_id,questao_id)
VALUES
(  'ED9E228A-8D1D-4F8F-A983-EAA754684447', '74571868-177D-B263-9965-700F2723BA15',  '23A50283-E406-EC39-347D-6D68044B2617'),
(  '359DBB24-8163-4532-8103-EFA0B4821BF6', '74571868-177D-B263-9965-700F2723BA15',  '3A6B406E-D83E-1E26-149E-1E19F268759A'),
(  '98CA21D0-E23B-4CA8-BE5D-03FBD3B838BE', '74571868-177D-B263-9965-700F2723BA15',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D'),
(  'F55F7F6D-314A-4506-B699-DD3CDBB3F502', '74571868-177D-B263-9965-700F2723BA15',  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2'),
(  'CBB65230-FFE7-43BF-B43F-FEEA25A6CEA0', '74571868-177D-B263-9965-700F2723BA15',  '2F936AE7-6B77-3ED8-CA4A-77945F856612'),
(  '5F807938-F551-42E0-8C93-B262AF77AB8A', '74571868-177D-B263-9965-700F2723BA15',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6'),
(  'D4BA23BB-6837-47A6-A693-3AF166883996', '74571868-177D-B263-9965-700F2723BA15',  'BC358B5E-6D78-34C6-0468-837ECA522878'),
(  '230D1B3B-217B-4C46-88D4-D8D47F640162', '74571868-177D-B263-9965-700F2723BA15',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C'),
(  '9D0C1ED8-8538-4CB9-90A9-AA1DE1FE90A7', '74571868-177D-B263-9965-700F2723BA15',  '783A2951-A279-A225-AE16-95CBB34DC7FB'),
(  'C9A5DF8A-52FB-4F8D-9F87-B1770DBDD35C', '74571868-177D-B263-9965-700F2723BA15',  'A84864C2-B45C-B065-BBB4-30869B3CD110'),

(  '09110371-1663-48A4-BA84-B0558420AC17', '38FA234D-1BC4-B469-E7B5-91ED1D385E94',  '23A50283-E406-EC39-347D-6D68044B2617'),
(  '97F5457F-EFBA-455D-B583-7982FC9DEC9A', '38FA234D-1BC4-B469-E7B5-91ED1D385E94',  '3A6B406E-D83E-1E26-149E-1E19F268759A'),
(  '2BB6030B-7839-4AD4-BA93-352E1BD2152E', '38FA234D-1BC4-B469-E7B5-91ED1D385E94',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D'),
(  '247778C6-44ED-4289-AC7C-53CEE73E3C95', '38FA234D-1BC4-B469-E7B5-91ED1D385E94',  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2'),
(  '3BCB465F-9DA8-4455-893E-514512E990EF', '38FA234D-1BC4-B469-E7B5-91ED1D385E94',  '2F936AE7-6B77-3ED8-CA4A-77945F856612'),
(  'CD2272DF-7B50-435C-9319-2051D0B51B60', '38FA234D-1BC4-B469-E7B5-91ED1D385E94',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6'),
(  '9BACFB7D-CEF5-4682-B820-AD63D36693AE', '38FA234D-1BC4-B469-E7B5-91ED1D385E94',  'BC358B5E-6D78-34C6-0468-837ECA522878'),
(  '9F1C4F0B-527E-4D32-954C-E52E615ADA51', '38FA234D-1BC4-B469-E7B5-91ED1D385E94',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C'),
(  '6A90373C-A73E-45DA-A1B4-DB5D694003F0', '38FA234D-1BC4-B469-E7B5-91ED1D385E94',  '783A2951-A279-A225-AE16-95CBB34DC7FB'),
(  '6AACB3C5-8789-4C2C-95C6-94C67ACA5272', '38FA234D-1BC4-B469-E7B5-91ED1D385E94',  'A84864C2-B45C-B065-BBB4-30869B3CD110'),

(  '86DBD939-2067-4D51-B22E-A72A959B3533', 'ED7F7CEE-1514-8D34-CDC7-B351B03B7FB4',  '23A50283-E406-EC39-347D-6D68044B2617'),
(  '41A8CAAF-FEF9-4BBC-AB62-63F9FA3E5347', 'ED7F7CEE-1514-8D34-CDC7-B351B03B7FB4',  '3A6B406E-D83E-1E26-149E-1E19F268759A'),
(  'E2BFEE5D-273C-4E28-A2FF-BA6F197F5BDC', 'ED7F7CEE-1514-8D34-CDC7-B351B03B7FB4',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D'),
(  '8BC84E85-83D7-4918-900D-E3B81E629D08', 'ED7F7CEE-1514-8D34-CDC7-B351B03B7FB4',  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2'),
(  '6B21EE40-4CD2-4757-B25B-E3209B025939', 'ED7F7CEE-1514-8D34-CDC7-B351B03B7FB4',  '2F936AE7-6B77-3ED8-CA4A-77945F856612'),
(  '2C58DACF-F940-4594-843D-1140CEA5F40C', 'ED7F7CEE-1514-8D34-CDC7-B351B03B7FB4',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6'),
(  'E508B25A-9A2F-4463-B087-B71CAEE192C8', 'ED7F7CEE-1514-8D34-CDC7-B351B03B7FB4',  'BC358B5E-6D78-34C6-0468-837ECA522878'),
(  '18FE857E-5944-43DB-85C3-82A3426772A6', 'ED7F7CEE-1514-8D34-CDC7-B351B03B7FB4',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C'),
(  'F56A3E93-CE39-44BB-9611-841A18A64B8B', 'ED7F7CEE-1514-8D34-CDC7-B351B03B7FB4',  '783A2951-A279-A225-AE16-95CBB34DC7FB'),
(  'BCE39737-6509-4EE4-AB42-C50D7CDA8690', 'ED7F7CEE-1514-8D34-CDC7-B351B03B7FB4',  'A84864C2-B45C-B065-BBB4-30869B3CD110'),

(  '7157E094-D76C-469C-9790-7A1751C0427E', 'E1BD8206-22F6-1ED0-5E2F-F4A24B3D48CD',  '23A50283-E406-EC39-347D-6D68044B2617'),
(  '861D0644-B04B-43E0-B292-571897CF3423', 'E1BD8206-22F6-1ED0-5E2F-F4A24B3D48CD',  '3A6B406E-D83E-1E26-149E-1E19F268759A'),
(  'B0CC8D36-6F18-4F0E-AFC5-ABF2030A1F3B', 'E1BD8206-22F6-1ED0-5E2F-F4A24B3D48CD',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D'),
(  '798D2538-A6A4-45FA-9C46-D139E845FCB3', 'E1BD8206-22F6-1ED0-5E2F-F4A24B3D48CD',  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2'),
(  '5E8F719E-68A4-47D1-960C-A6B14262950F', 'E1BD8206-22F6-1ED0-5E2F-F4A24B3D48CD',  '2F936AE7-6B77-3ED8-CA4A-77945F856612'),
(  'B9F9F4F4-8156-4723-95F2-036FD1B72560', 'E1BD8206-22F6-1ED0-5E2F-F4A24B3D48CD',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6'),
(  '0DD15DCB-C4B3-44F1-8647-124D15753AF0', 'E1BD8206-22F6-1ED0-5E2F-F4A24B3D48CD',  'BC358B5E-6D78-34C6-0468-837ECA522878'),
(  '13207C9B-1FCF-404F-B728-39387C8C7769', 'E1BD8206-22F6-1ED0-5E2F-F4A24B3D48CD',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C'),
(  '97D24FB0-AEE3-404C-BA6D-18E3FFB27570', 'E1BD8206-22F6-1ED0-5E2F-F4A24B3D48CD',  '783A2951-A279-A225-AE16-95CBB34DC7FB'),
(  'EB43335C-70DF-4222-85C2-ADAFE7F5BA8E', 'E1BD8206-22F6-1ED0-5E2F-F4A24B3D48CD',  'A84864C2-B45C-B065-BBB4-30869B3CD110'),

(  '82D3D552-D83D-447D-9229-4C318BE0E192', 'D91B156E-5B2E-AA63-A681-7E11D294AD4C',  'CDAE91B1-D657-7999-3AF0-98EDC9AB354A'),
(  'E9984E99-498A-4894-A410-1E07C3A9DB9D', 'D91B156E-5B2E-AA63-A681-7E11D294AD4C',  '4D7AC40A-CFDE-15D4-FEA3-09B829B447C2'),
(  'AAB6F551-E302-4C2E-8998-510882B2C328', 'D91B156E-5B2E-AA63-A681-7E11D294AD4C',  'DFAADCBE-919B-6E57-B4BC-B7E73E8AC570'),
(  'FC7C10B6-AC35-4D4B-99AB-3A5902D53C96', 'D91B156E-5B2E-AA63-A681-7E11D294AD4C',  '4AFD3809-5274-DEA3-EC85-19498BBCC7F3'),
(  '7A4FBAB0-0E22-4EE2-AECD-188AFCC89AA7', 'D91B156E-5B2E-AA63-A681-7E11D294AD4C',  '7C41465A-AE84-DAB9-814C-412794FEE95E'),
(  '840B64F9-7465-4FBB-93AE-2F978B9984BF', 'D91B156E-5B2E-AA63-A681-7E11D294AD4C',  '4D8EEA17-1CBC-8121-5B01-A788D254187C'),
(  'B41698A9-9E31-4AA0-89AC-8423BD6C7DDF', 'D91B156E-5B2E-AA63-A681-7E11D294AD4C',  '1234B457-DADD-1B2B-3EBC-5CFCDA392261'),
(  '0D65907B-8606-43AD-81E9-06B887F1B332', 'D91B156E-5B2E-AA63-A681-7E11D294AD4C',  '562AA2CD-4A57-6E72-A760-BBC26C8C1A3D'),
(  '2734BBA0-0714-483C-8E58-8E02FA9768C3', 'D91B156E-5B2E-AA63-A681-7E11D294AD4C',  '136A733D-5C33-2935-C859-DDA9AD25B0BB'),
(  'E7DC97B4-E85C-412E-9F2C-7E8735551F58', 'D91B156E-5B2E-AA63-A681-7E11D294AD4C',  '61240F89-7CE3-CC4A-8912-BFB6E5A785F8');


INSERT INTO [alternativa] (id, questao_id, texto, alternativa_correta)
VALUES
(  '53018B7C-032A-C05D-73A3-A63DBA415241',  '23A50283-E406-EC39-347D-6D68044B2617', 'Utilizar blacklists para rejeitar e-mails de fontes conhecidas de spam' , 1),
(  '7C77E685-E833-74B7-8B01-7570C7595DAD',  '23A50283-E406-EC39-347D-6D68044B2617', 'Permitir apenas o recebimento de mensagens oriundas de remetentes autenticados em SMTP' , 0),
(  '3671A258-A8D8-AA63-1709-CC6662F9422F',  '23A50283-E406-EC39-347D-6D68044B2617', 'Utilizar filtros baseados em relatos, onde o sistema *aprende* a partir de mensagens marcadas como spam pelos usu�rios' , 0),
(  '6AB373B5-0687-F05F-FA84-08A907D596D9',  '23A50283-E406-EC39-347D-6D68044B2617', 'Recusar temporariamente uma mensagem e esperar por sua retransmiss�o, que s� costuma ocorrer a partir de MTAs leg�timos' , 0),
(  'C2051581-3058-49F8-9727-42A8EB5650AF',  '23A50283-E406-EC39-347D-6D68044B2617', 'Usar detec��o por camadas para identificar padr�es de spam, interrompendo em tempo real as mensagens indesejadas.' , 0),
(  '0524ECCA-35BB-4BBA-2A95-0DA6C3794098',  '3A6B406E-D83E-1E26-149E-1E19F268759A', 'I e II;' , 0),
(  'B82748A5-94E4-2511-A2F6-653F2070898C',  '3A6B406E-D83E-1E26-149E-1E19F268759A', 'I e III;' , 0),
(  'CF765C25-D65E-B133-79BD-9A3838952EE2',  '3A6B406E-D83E-1E26-149E-1E19F268759A', 'II e III;' , 1),
(  'CF482041-84A4-A798-79CD-6B0FC920128A',  '3A6B406E-D83E-1E26-149E-1E19F268759A', 'III;' , 0),
(  '1B585338-38C4-2CCB-FB45-EBAD1A6C152F',  '3A6B406E-D83E-1E26-149E-1E19F268759A', 'I, II e III.' , 0),
(  '284C1EB7-288E-6DB7-F6EC-E685E64D821F',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D', 'selecionar as partes da norma aplic�veis � empresa, recebendo assim a certifica��o apenas sobre essas partes implementadas ' , 0),
(  '5D2EAED0-572C-FC70-7B17-56E80EB337EE',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D', 'realizar previamente uma an�lise de risco com abordagem quantitativa' , 0),
(  '697DE067-3595-1152-96E9-5963123B9DF3',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D', 'definir uma pol�tica de seguran�a com base no uso efetivo de um conjunto t�cnico de ferramentas, de reconhecida efici�ncia ' , 1),
(  'F84D9A29-A278-0047-3D49-D7E8B86E9354',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D', 'garantir que os gestores de seguran�a realizem an�lises cr�ticas do SGSI em intervalos regulares' , 0),
(  '1CCE6AB6-E84F-7707-E12E-270BF75CC38C',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D', 'justificar, na declara��o de aplicabilidade, o motivo da n�o utiliza��o de controles listados na pr�pria norma.' , 0),
(  '64436A2B-BAF9-15BE-3AEA-B3B1B19D1A28',  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2', 'CBC (Cipher-block chaining)' , 0),
(  '7A66C8B9-2AE4-23E8-A54E-5638BD0D7277',  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2', 'ECB (Electronic Code Book)' , 1),
(  '46591DB4-5DA2-A6B9-895D-0BAABB3DB817',  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2', 'CFB (Cipher feedback)' , 0),
(  'EB1A361C-4204-6917-9816-70438B914EA3',  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2', 'OFB (Output feedback)' , 0),
(  'DD534C8F-C643-64C2-8463-5F8B47E49126',  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2', 'ICM (Integer Counter Mode)' , 0),
(  'F7DEEC72-DC50-7C29-8D65-7B6F8DCB2638',  '2F936AE7-6B77-3ED8-CA4A-77945F856612', '1000000000000010' , 1),
(  'CE457DBD-E5F5-EE55-FD50-9C38918EF9A3',  '2F936AE7-6B77-3ED8-CA4A-77945F856612', '1111111111111110' , 0),
(  'E39E3A43-E7AC-5D36-7C43-715056415F8C',  '2F936AE7-6B77-3ED8-CA4A-77945F856612', '0111111111111110' , 0),
(  'E1CF5813-1D76-E3E2-AF8B-0801F1D8FB23',  '2F936AE7-6B77-3ED8-CA4A-77945F856612', '1010101010101010' , 0),
(  'C3613C06-176F-CB2E-6276-B99D6086F513',  '2F936AE7-6B77-3ED8-CA4A-77945F856612', '0101010101010101' , 0),
(  '50974627-4F72-5DD4-456D-BB657B1C8D24',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6', 'causa overflow em representa��o de 8 bits em complemento a 2' , 0),
(  '55293613-0142-AE23-E063-D61D99DAC7B4',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6', 'causa overflow em representa��o de 16 bits em complemento a 2' , 0),
(  '158E597D-6354-C49C-777A-CCC215D243B6',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6', 'n�o pode ser representado em 8 bits, j� que a base � 16' , 1),
(  '1A627284-C7A4-66FC-CD8D-E55665C96315',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6', 'produz um inteiro negativo em representa��o de 16 bits em complemento a 2' , 0),
(  '24C3D79C-9621-72D1-4CD9-2C8D21C54B0B',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6', 'produz um inteiro positivo em representa��o de 8 bits em complemento a 2' , 0),
(  '9E662331-102D-E4BF-F633-6D0DEDD0578B',  'BC358B5E-6D78-34C6-0468-837ECA522878', 'produz uma c�pia do dado em mem�ria ROM' , 0),
(  'A9768AC1-6E09-E71E-5AC4-B5B82A3D3FCA',  'BC358B5E-6D78-34C6-0468-837ECA522878', 'n�o usa a mem�ria RAM' , 1),
(  '922B4967-50D0-8488-0858-CBEE6D72F44D',  'BC358B5E-6D78-34C6-0468-837ECA522878', 'pode acarretar perda de precis�o' , 0),
(  'C8475A66-6989-78D7-576D-65A27B619961',  'BC358B5E-6D78-34C6-0468-837ECA522878', '� t�o r�pido quanto o acesso a dados em mem�ria RAM' , 0),
(  'F9D8A748-A3E8-D84F-2297-159BCC39AC4A',  'BC358B5E-6D78-34C6-0468-837ECA522878', '� mais lento que o acesso a dados em mem�ria RAM' , 0),
(  'BCAC3B59-7E67-DBD8-4475-7123414197CC',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C', 'minor fit' , 0),
(  'D5DC0211-E4BE-A91C-F4C2-E97370784C1A',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C', 'save fit' , 0),
(  '2A827766-1679-0FE4-5CA9-89D7A5DFF285',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C', 'best fit' , 1),
(  'EDF2B9A4-587D-9D6B-9F4E-640D3986BCC3',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C', 'first fit' , 0),
(  '8667E501-B9D2-1605-3CE5-24C95CBE7F22',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C', 'worst fit' , 0),
(  '749A23A6-06C3-6084-CEC2-2A554A3188D5',  '783A2951-A279-A225-AE16-95CBB34DC7FB', 'descri��o das opera��es, protocolo de Internet e tipo de arquivo' , 1),
(  '48B55EDC-3C33-9D89-DCA6-BBA8AA306891',  '783A2951-A279-A225-AE16-95CBB34DC7FB', 'localiza��o do servi�o, criptografia e protocolo de comunica��o' , 0),
(  '9C5854E1-AC07-3652-FE07-88C1E85C51B4',  '783A2951-A279-A225-AE16-95CBB34DC7FB', 'm�todo de conex�o, protocolo de Internet e local da implementa��o' , 0),
(  '651181A6-607B-CD79-8EDB-27617E438F7E',  '783A2951-A279-A225-AE16-95CBB34DC7FB', 'localiza��o, assinatura digital e componente' , 0),
(  '7EB9A2BB-30C6-B1A9-A2E9-14DED13BAAA6',  '783A2951-A279-A225-AE16-95CBB34DC7FB', 'interface, liga��o e local da implementa��o' , 0),
(  '94787D61-A5B3-ABBF-5DD7-C2C72E43695D',  'A84864C2-B45C-B065-BBB4-30869B3CD110', 'o syslog utiliza o protocolo de transporte UDP, o qual faz controle de fluxo' , 0),
(  'BE12195E-8985-D114-A0E5-BA45A739EDD6',  'A84864C2-B45C-B065-BBB4-30869B3CD110', 'o servidor centralizador enviar� mensagens aos clientes, informando que est� com a fila cheia' , 0),
(  'CA5A163D-86D1-9733-8684-E987B8A84782',  'A84864C2-B45C-B065-BBB4-30869B3CD110', 'o cliente armazenar� temporariamente as mensagens at� conseguir transmiti-la ao servidor centralizador' , 1),
(  '847F8D52-8BC4-8A3A-7B4B-4F8BE98303F7',  'A84864C2-B45C-B065-BBB4-30869B3CD110', 'o servidor centralizador descartar� todas as mensagens que n�o conseguir armazenar, independentemente de sua severidade' , 0),
(  '7506B9DE-D5BF-25AC-BB94-53C49E27052E',  'A84864C2-B45C-B065-BBB4-30869B3CD110', 'o cliente descartar� todas as mensagens que n�o conseguir transmitir ao servidor centralizador, independentemente de sua severidade ' , 0),

('44A03947-B933-B1A1-E5CB-2271E5E0E2E5','CDAE91B1-D657-7999-3AF0-98EDC9AB354A','Adi��o. ',1),
('234D5117-495E-6FC7-7D83-73E1AA1BAF40','CDAE91B1-D657-7999-3AF0-98EDC9AB354A','Ades�o.',0),
('4D84A929-24BC-BC2E-D549-C45AE8DAEA4D','CDAE91B1-D657-7999-3AF0-98EDC9AB354A','Doen�a.',0),
('754DED2A-CC3C-E954-9743-28BED75E9CCE','CDAE91B1-D657-7999-3AF0-98EDC9AB354A','V�cio. ',0),
('D8A74156-C844-4A32-2869-6954E2525180','CDAE91B1-D657-7999-3AF0-98EDC9AB354A','Tortura.',0),
('7D49EFBC-C33D-CC8F-ECB9-6E6E2D0B9328','4D7AC40A-CFDE-15D4-FEA3-09B829B447C2','Es la una menos quince.',0),
('3D44477A-781F-C49C-32C6-A3808382CA36','4D7AC40A-CFDE-15D4-FEA3-09B829B447C2','Son las una y cuarenta y cinco. ',1),
('6C0A634A-63E7-CCA0-162A-78F8ECC5BFB0','4D7AC40A-CFDE-15D4-FEA3-09B829B447C2','Son las dos menos cuarto. ',0),
('423D6AAF-AE5A-BA65-CCE5-EE7147C3D565','4D7AC40A-CFDE-15D4-FEA3-09B829B447C2','Es la una y quince.',0),
('6CCC59FE-3888-968A-8E56-D1BDDE98AB18','4D7AC40A-CFDE-15D4-FEA3-09B829B447C2','Son las dos y quince.',0),
('A83ABD95-F6F2-B4AA-2CC9-4070CA8939E1','DFAADCBE-919B-6E57-B4BC-B7E73E8AC570','teno, conozco, empiezo, vengo, hago',0),
('E8CCE9EF-8085-B3AD-A60B-B1EA2C0ECC24','DFAADCBE-919B-6E57-B4BC-B7E73E8AC570','tengo, co�eco, empiezo, vengo, hago',0),
('6997AB67-8986-E5BC-3231-1C42DE5FC622','DFAADCBE-919B-6E57-B4BC-B7E73E8AC570','tengo, conozco, empezo, vengo, hazo',0),
('381C97EE-BE3B-B2DD-28C3-4C836DD2C59F','DFAADCBE-919B-6E57-B4BC-B7E73E8AC570','tengo, conozco, empiezo, ve�o, hago',0),
('FBD77640-47BB-226E-E66A-EC2C84559586','DFAADCBE-919B-6E57-B4BC-B7E73E8AC570','tengo, conzoco, empiezo, vengo, hago',1),
('35C78A7B-1917-7521-5BA5-EC63202430DB','4AFD3809-5274-DEA3-EC85-19498BBCC7F3','murrido, decido, hacido, visto, ponido, fre�do',0),
('2128B126-DE86-8C8B-019C-8820C77AFDAD','4AFD3809-5274-DEA3-EC85-19498BBCC7F3','muerto, dicho, hecho, visto, puesto, frito',1),
('5956A396-C7CF-FCC9-C715-55918E7730B0','4AFD3809-5274-DEA3-EC85-19498BBCC7F3','murrido, dicho, hacido, ve�sto, puesto, fre�do',0),
('1BBBDF38-6788-85AC-FC18-8B19CD3A8B35','4AFD3809-5274-DEA3-EC85-19498BBCC7F3','muerto, decho, hacido, visto, ponido, frito',0),
('6C8E8815-52A0-AC49-EC48-DA0CBCE069DA','4AFD3809-5274-DEA3-EC85-19498BBCC7F3','muerto, deicho, hecho, visto, puesto, fre�do',0),
('2A82733E-C077-BD29-C364-97E57AC57C87','7C41465A-AE84-DAB9-814C-412794FEE95E','Mi madre est� cansada suios alumnos.',0),
('C241D3A4-A474-2462-844A-6D617B2B653D','7C41465A-AE84-DAB9-814C-412794FEE95E','Estoy decepcionado con tuya actitud.',0),
('BA4E7C86-EE73-2957-2369-3C96A3CCB89E','7C41465A-AE84-DAB9-814C-412794FEE95E','Es peque�a, pero mi casa es muy agradable. ',1),
('5206EA97-98D5-F476-E24C-276C69B97A0E','7C41465A-AE84-DAB9-814C-412794FEE95E','Creo que Isabel habl� con suyos hijos.',0),
('A7D70188-82FA-5E81-C744-537338B56E79','7C41465A-AE84-DAB9-814C-412794FEE95E','Mia fam�lia es mi tesoro.',0),
('A94ABDD9-CDA7-A653-C5DD-5E01C8FB6819','4D8EEA17-1CBC-8121-5B01-A788D254187C','Seis de febrero de mil novecientos ochenta y siete.',1),
('52C5D776-A9E5-9B15-E1EB-A74C4F6B4841','4D8EEA17-1CBC-8121-5B01-A788D254187C','Seis de febrero de mil novecentos ochenta y siete.',0),
('3B21586B-655B-A123-D86E-4B3996D8A30E','4D8EEA17-1CBC-8121-5B01-A788D254187C','Seis de febreiro de mil novecentos ochenta y siete.',0),
('8A5F54A8-B7B1-64B8-DAD9-B1EA59C9A48B','4D8EEA17-1CBC-8121-5B01-A788D254187C','Seis de febrero de mil novecentos ochenta y sete.',0),
('1E4E43E4-887D-72BE-2E71-2B6F9ED4B4B6','4D8EEA17-1CBC-8121-5B01-A788D254187C','Sieis de febreiro de mil novecientos y ochenta y siete.',0),
('D112E87B-4624-49DE-412B-82D04EBA6819','1234B457-DADD-1B2B-3EBC-5CFCDA392261','Pret�rito imperfecto, pret�rito indefinido, pret�rito perfecto.',1),
('BDB23291-8613-5DE2-7A2A-6A28C93D7CD4','1234B457-DADD-1B2B-3EBC-5CFCDA392261','Pret�rito imperfecto, pret�rito perfecto, pret�rito pluscuamperfecto.',0),
('8A156596-D35C-6DB9-D9F7-FC936EB78D2D','1234B457-DADD-1B2B-3EBC-5CFCDA392261','Pret�rito indefinido, pret�rito imperfecto, pret�rito pluscuamperfecto.',0),
('5C6ACC09-13A2-BBF8-06AF-57ECBBD7EB3E','1234B457-DADD-1B2B-3EBC-5CFCDA392261','Pret�rito imperfecto, pret�rito indefinido, pret�rito pluscuamperfecto.',0),
('89A1E50F-FB91-F348-BFDF-DC592ACFF8AD','1234B457-DADD-1B2B-3EBC-5CFCDA392261','Pret�rito imperfecto, pret�rito indefinido, pret�rito anterior.',0),
('2362A02E-6547-5D62-6B8B-9852E495517D','562AA2CD-4A57-6E72-A760-BBC26C8C1A3D','te, lo ',0),
('3E7519F4-9B67-0B65-E26A-C12BA244A4C4','562AA2CD-4A57-6E72-A760-BBC26C8C1A3D','te, le',0),
('10461653-9AB3-99D2-85C3-589713D2AE20','562AA2CD-4A57-6E72-A760-BBC26C8C1A3D','lo, lo ',1),
('3DD15515-9A3F-2653-7E22-2D851A006846','562AA2CD-4A57-6E72-A760-BBC26C8C1A3D','lo, les ',0),
('CED26E9A-45AA-C5FF-54E0-3CF72996315A','562AA2CD-4A57-6E72-A760-BBC26C8C1A3D','te, los',0),
('743E4201-5AB7-533D-0DFB-DB7FB314FE6D','136A733D-5C33-2935-C859-DDA9AD25B0BB','Los clientes tienen un perfil muy variado. Por esto, tenemos que fabricar zapatillas que atiendan a las mas distintas necesidades y gustos.',1),
('E359D393-C0AC-71A7-B5E7-9C687513D196','136A733D-5C33-2935-C859-DDA9AD25B0BB','Estes trabajadores est�n muy bien entrenados.',0),
('BD2416C7-0865-4AD4-658C-3972A577BE42','136A733D-5C33-2935-C859-DDA9AD25B0BB','Esto anuncio de hoy me parece mejor, pero aquel que sali� ayer te viene como anillo en el dedo.',0),
('3C6AF35D-3D84-A1C2-C3E7-061D18EABA34','136A733D-5C33-2935-C859-DDA9AD25B0BB','De lo m�o cuido yo. Preoc�patelo con lo tuyo.',0),
('D9F3A7C7-AB86-18DE-F984-BD6301AC6AFE','136A733D-5C33-2935-C859-DDA9AD25B0BB','Dicen que en esto de las celulas tronco est�n lo futuro de la medicina.',0),
('E4EA7669-AA75-B139-1FE7-21B66D052F7D','61240F89-7CE3-CC4A-8912-BFB6E5A785F8','Grave, aguda, aguda, grave, aguda.',0),
('0ACB8480-73F5-1781-CCED-F8AFAF299394','61240F89-7CE3-CC4A-8912-BFB6E5A785F8','Aguda, esdr�jula, aguda, grave, aguda. ',0),
('98812F89-A9C2-8795-7321-C66839069531','61240F89-7CE3-CC4A-8912-BFB6E5A785F8','Grave, esdr�jula, aguda, aguda, grave. ',1),
('7C94DC08-44D3-0BE3-1EA8-3BDAC6EB1213','61240F89-7CE3-CC4A-8912-BFB6E5A785F8','Grave, esdr�jula, aguda, grave, aguda.',0),
('1C1A7012-EA2A-D768-2C3D-545ADE3E3550','61240F89-7CE3-CC4A-8912-BFB6E5A785F8','Aguda, grave, esdr�jula, aguda, grave.',0);


INSERT INTO [turma] (id,nome,professor_id)
VALUES
(  'DE4E6DF2-1842-21A6-F5DE-18BB234D3EFD','UNIRITTER-20220110-1',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '14A36DFA-5DA6-3572-1E04-8BA71BAA519C','UNP-20220110-0',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '943B2E18-C593-3C42-A60D-2976D7747492','FG-20220110-1',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '12BE106F-615B-B53C-6AEF-1457132179CA','UNISUL-20210210-1',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  'B5B94925-1613-1688-C2F9-5A62126F275E','MORUMBI-20210210-3',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E')


INSERT INTO [matricula] (id,aluno_id,TurmaId)
VALUES
(  'E4B3F921-E313-068A-4ACB-967EE7E287E0',  'C2C93C0B-7A51-B67A-E7E7-BB8A35794681',  'DE4E6DF2-1842-21A6-F5DE-18BB234D3EFD'),
(  'AEA0DE88-4485-3B29-EEE2-2833650546E7',  '8CA57761-76BD-4582-5D1B-666F4F1E62DF',  '943B2E18-C593-3C42-A60D-2976D7747492'),
(  'CD44BD1B-F20E-7D0B-E31D-0278E52EAB59',  '222680E5-DEE8-1348-2E9E-3C64976D63BE',  '12BE106F-615B-B53C-6AEF-1457132179CA'),
(  'D45C5BD5-5DDA-B295-306E-9A936B49453D',  'F65097F9-7A2C-4876-C301-9F1A9798BE0C',  'B5B94925-1613-1688-C2F9-5A62126F275E')


INSERT INTO [avaliacao] (id, turma_id, prova_id, nome)
VALUES 
('1F34DD28-AF77-4F0D-9C59-00810D187DDA', 'DE4E6DF2-1842-21A6-F5DE-18BB234D3EFD', '74571868-177D-B263-9965-700F2723BA15', 'A1'),
('1FE4A6D6-1E93-4647-A000-6F5F87E39A3E', '943B2E18-C593-3C42-A60D-2976D7747492', '38FA234D-1BC4-B469-E7B5-91ED1D385E94', 'A2'),
('0D55D120-9DB5-4CA7-AC7C-CF440EE8502C', '12BE106F-615B-B53C-6AEF-1457132179CA', 'ED7F7CEE-1514-8D34-CDC7-B351B03B7FB4', 'A3'),
('5E66CEA3-DDE2-4D5C-B77D-109174B3EC90', 'B5B94925-1613-1688-C2F9-5A62126F275E', 'E1BD8206-22F6-1ED0-5E2F-F4A24B3D48CD', 'A4'),
('253A345A-7B55-4FC3-B2FB-96667D82870E', 'B5B94925-1613-1688-C2F9-5A62126F275E', 'D91B156E-5B2E-AA63-A681-7E11D294AD4C', 'A5');


INSERT INTO [avaliacao_matricula] (id, avaliacao_id, matricula_id, nota)
VALUES
('1D6138BB-1F55-4C7F-85EB-5E54ECB5E645', '1F34DD28-AF77-4F0D-9C59-00810D187DDA', 'E4B3F921-E313-068A-4ACB-967EE7E287E0', 7),
('76BFE45A-800C-47F9-A10B-C89ECF1F92F2', '1FE4A6D6-1E93-4647-A000-6F5F87E39A3E', 'AEA0DE88-4485-3B29-EEE2-2833650546E7', 9.5);
--('CCD3D1E0-87C9-4568-97ED-401C47C86462', '253A345A-7B55-4FC3-B2FB-96667D82870E', 'D45C5BD5-5DDA-B295-306E-9A936B49453D', 4);


INSERT INTO [folha_resposta] (id, avaliacao_matricula_id, questao_id, alternativa_id)
VALUES
('74DFE7B1-7C1F-43B2-A034-E478E917E3C0', '1D6138BB-1F55-4C7F-85EB-5E54ECB5E645', '23A50283-E406-EC39-347D-6D68044B2617','53018B7C-032A-C05D-73A3-A63DBA415241'),
('A3E93270-A3EE-47B2-880F-E7911FEE8138', '1D6138BB-1F55-4C7F-85EB-5E54ECB5E645', '3A6B406E-D83E-1E26-149E-1E19F268759A','B82748A5-94E4-2511-A2F6-653F2070898C'),
('69F0EB1B-1106-4200-A7BD-2C58523049D4', '1D6138BB-1F55-4C7F-85EB-5E54ECB5E645', '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D','697DE067-3595-1152-96E9-5963123B9DF3'),
('16B87D89-25A1-4BE4-97DD-CA4B1AC68C90', '1D6138BB-1F55-4C7F-85EB-5E54ECB5E645', '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2','7A66C8B9-2AE4-23E8-A54E-5638BD0D7277'),
('120E0510-0BA4-4813-959C-84C0B597F814', '1D6138BB-1F55-4C7F-85EB-5E54ECB5E645', '2F936AE7-6B77-3ED8-CA4A-77945F856612','C3613C06-176F-CB2E-6276-B99D6086F513'),
('996F4B96-F271-4604-A846-39258E094CDA', '1D6138BB-1F55-4C7F-85EB-5E54ECB5E645', 'C8D6156D-7476-5647-E7C3-8DE0D22591D6','55293613-0142-AE23-E063-D61D99DAC7B4'),
('D10F51AD-17CA-4F77-B6A7-5E07D005C9BD', '1D6138BB-1F55-4C7F-85EB-5E54ECB5E645', 'BC358B5E-6D78-34C6-0468-837ECA522878','A9768AC1-6E09-E71E-5AC4-B5B82A3D3FCA'),
('0F82B338-04A7-4420-92F7-7AE9E19F17A7', '1D6138BB-1F55-4C7F-85EB-5E54ECB5E645', '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C','EDF2B9A4-587D-9D6B-9F4E-640D3986BCC3'),
('725B30BD-D773-4049-BE64-00DA1902E049', '1D6138BB-1F55-4C7F-85EB-5E54ECB5E645', '783A2951-A279-A225-AE16-95CBB34DC7FB','749A23A6-06C3-6084-CEC2-2A554A3188D5'),
('4A208ADF-A442-4E62-8C86-F86AF1D60C68', '1D6138BB-1F55-4C7F-85EB-5E54ECB5E645', 'A84864C2-B45C-B065-BBB4-30869B3CD110','CA5A163D-86D1-9733-8684-E987B8A84782');

--('ACC31C66-9E6F-4B6F-96D7-1CC5A38406A3', 'CCD3D1E0-87C9-4568-97ED-401C47C86462', 'CDAE91B1-D657-7999-3AF0-98EDC9AB354A','44A03947-B933-B1A1-E5CB-2271E5E0E2E5'),
--('E0F5D947-9E43-4136-9A7B-DBF335C34AE7', 'CCD3D1E0-87C9-4568-97ED-401C47C86462', '4D7AC40A-CFDE-15D4-FEA3-09B829B447C2','3D44477A-781F-C49C-32C6-A3808382CA36'),
--('2BC83A50-D9FE-4860-BE06-066C0262FFEE', 'CCD3D1E0-87C9-4568-97ED-401C47C86462', 'DFAADCBE-919B-6E57-B4BC-B7E73E8AC570','FBD77640-47BB-226E-E66A-EC2C84559586'),
--('7C01C962-1032-4017-B732-5BFFB782FE34', 'CCD3D1E0-87C9-4568-97ED-401C47C86462', '4AFD3809-5274-DEA3-EC85-19498BBCC7F3','2128B126-DE86-8C8B-019C-8820C77AFDAD'),
--('63992C62-7C71-47BA-A0F5-2EFC22122D0D', 'CCD3D1E0-87C9-4568-97ED-401C47C86462', '7C41465A-AE84-DAB9-814C-412794FEE95E','2A82733E-C077-BD29-C364-97E57AC57C87'),
--('4CACAC58-8FF4-4265-8209-D0831F9CD324', 'CCD3D1E0-87C9-4568-97ED-401C47C86462', '4D8EEA17-1CBC-8121-5B01-A788D254187C','3B21586B-655B-A123-D86E-4B3996D8A30E'),
--('ECA78853-A351-4B9E-9B8C-8D1F32C72EDA', 'CCD3D1E0-87C9-4568-97ED-401C47C86462', '1234B457-DADD-1B2B-3EBC-5CFCDA392261','5C6ACC09-13A2-BBF8-06AF-57ECBBD7EB3E'),
--('DC0B2ED1-8E89-471F-9504-409101DEB445', 'CCD3D1E0-87C9-4568-97ED-401C47C86462', '562AA2CD-4A57-6E72-A760-BBC26C8C1A3D','2362A02E-6547-5D62-6B8B-9852E495517D'),
--('AECD0A69-216F-4F9A-82BB-5C18DAA3BFA5', 'CCD3D1E0-87C9-4568-97ED-401C47C86462', '136A733D-5C33-2935-C859-DDA9AD25B0BB','E359D393-C0AC-71A7-B5E7-9C687513D196'),
--('26F26F8B-F193-4CAD-9D44-B8A99994D9D0', 'CCD3D1E0-87C9-4568-97ED-401C47C86462', '61240F89-7CE3-CC4A-8912-BFB6E5A785F8','E4EA7669-AA75-B139-1FE7-21B66D052F7D');
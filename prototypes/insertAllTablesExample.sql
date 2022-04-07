
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
		   ('4DD3B6B6-80DA-AA34-13B8-78750251267D'
           ,'Neville Caetano'
           ,'nevillecaetano@animaeducacao.combr'
           ,'VGY61ENH5JK'
           ,'aluno')
GO

INSERT INTO [professor] (id,usuario_id)
VALUES
(  'EC44538B-C8D3-8842-D336-8C4E371B7B9E',  '6C816AE5-8669-A80E-73A7-01F487478338')


INSERT INTO [aluno] (id,usuario_id)
VALUES
(  'C2C93C0B-7A51-B67A-E7E7-BB8A35794681',  '4DD3B6B6-80DA-AA34-13B8-78750251267D')


INSERT INTO [prova] (id, nome,professor_id)
VALUES
(  '74571868-177D-B263-9965-700F2723BA15','ANALISE E DESENVOLVIMENTO DE SISTEMAS',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E');


INSERT INTO [questao] (id,enunciado,professor_id)
VALUES
(  '23A50283-E406-EC39-347D-6D68044B2617','Procurando minimizar o número de spams que uma empresa recebe, os administradores de rede resolveram implementar a técnica de greylist, que consiste em: ', 'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '3A6B406E-D83E-1E26-149E-1E19F268759A','Em relação a assinaturas digitais, analise as afirmativas a seguir: I. Certificado categoria S2 é o certificado usado para assinatura digital, com tamanho mínimo de 1024 bits, gerado por software e armazenado em um token. II. A verificação da assinatura digital de um documento eletrônico é realizada através da chave pública do remetente do documento. III. O DSA, algoritmo usado para assinaturas digitais, possui uma variante que utiliza curvas elípticas. Está correto somente o que se afirma em:' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D','Uma empresa deseja ser certificada na implementação da norma ISO 27001. Para tal, ela deve seguir com rigor o que preconiza a norma, como por exemplo:' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2','Para criptografar mensagens de tamanho arbitrário, existem vários modos de operação especificando como a criptografia será aplicada. Um desses modos é frágil em termos de segurança, pois não oculta o padrão de dados da mensagem original, mantendo-o na mensagem codificada. Esse modo de operação, menos seguro, é o:',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '2F936AE7-6B77-3ED8-CA4A-77945F856612','O número inteiro –2 (menos dois) tem a seguinte representação em 16 bits, usando complemento a 2:' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  'C8D6156D-7476-5647-E7C3-8DE0D22591D6','O resultado da multiplicação entre os inteiros 7F16 x 1216, ambos representados em complemento a 2 na base 16' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  'BC358B5E-6D78-34C6-0468-837ECA522878','O acesso a dados em registradores internos da Unidade Central de Processamento (UCP):' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C','A estratégia de alocação de memória que busca o menor espaço livre suficiente para satisfazer cada requisição denomina-se:' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '783A2951-A279-A225-AE16-95CBB34DC7FB','Segundo Ian Sommerville, as arquiteturas orientadas a serviços (SOA) são uma forma de desenvolvimento de sistemas distribuídos em que os componentes de sistema são serviços autônomos, executando em computadores geograficamente distribuídos. Para que  acesso a esses serviços ocorra, são utilizados alguns padrões, dentre os quais estão o SOAP, WSDL e WS-BPEL. A linguagem WSDL é baseada em XML e tem como função especificar um serviço (web service) considerando os seguintes aspectos:',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  'A84864C2-B45C-B065-BBB4-30869B3CD110','Cristiano implementou o syslog nos servidores Linux que administra com o intuito de enviar todas as mensagens de log para um único servidor, que centralizará todos os logs da rede. Cristiano não está preocupado com a quantidade de mensagens de log  transmitidas entre os clientes e o servidor centralizador de log, pois:',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E');


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
(  'C9A5DF8A-52FB-4F8D-9F87-B1770DBDD35C', '74571868-177D-B263-9965-700F2723BA15',  'A84864C2-B45C-B065-BBB4-30869B3CD110');



INSERT INTO [alternativa] (id, questao_id, texto, alternativa_correta)
VALUES
(  '53018B7C-032A-C05D-73A3-A63DBA415241',  '23A50283-E406-EC39-347D-6D68044B2617', 'Utilizar blacklists para rejeitar e-mails de fontes conhecidas de spam' , 1),
(  '7C77E685-E833-74B7-8B01-7570C7595DAD',  '23A50283-E406-EC39-347D-6D68044B2617', 'Permitir apenas o recebimento de mensagens oriundas de remetentes autenticados em SMTP' , 0),
(  '3671A258-A8D8-AA63-1709-CC6662F9422F',  '23A50283-E406-EC39-347D-6D68044B2617', 'Utilizar filtros baseados em relatos, onde o sistema *aprende* a partir de mensagens marcadas como spam pelos usuários' , 0),
(  '6AB373B5-0687-F05F-FA84-08A907D596D9',  '23A50283-E406-EC39-347D-6D68044B2617', 'Recusar temporariamente uma mensagem e esperar por sua retransmissão, que só costuma ocorrer a partir de MTAs legítimos' , 0),
(  'C2051581-3058-49F8-9727-42A8EB5650AF',  '23A50283-E406-EC39-347D-6D68044B2617', 'Usar detecção por camadas para identificar padrões de spam, interrompendo em tempo real as mensagens indesejadas.' , 0),
(  '0524ECCA-35BB-4BBA-2A95-0DA6C3794098',  '3A6B406E-D83E-1E26-149E-1E19F268759A', 'I e II;' , 0),
(  'B82748A5-94E4-2511-A2F6-653F2070898C',  '3A6B406E-D83E-1E26-149E-1E19F268759A', 'I e III;' , 0),
(  'CF765C25-D65E-B133-79BD-9A3838952EE2',  '3A6B406E-D83E-1E26-149E-1E19F268759A', 'II e III;' , 1),
(  'CF482041-84A4-A798-79CD-6B0FC920128A',  '3A6B406E-D83E-1E26-149E-1E19F268759A', 'III;' , 0),
(  '1B585338-38C4-2CCB-FB45-EBAD1A6C152F',  '3A6B406E-D83E-1E26-149E-1E19F268759A', 'I, II e III.' , 0),
(  '284C1EB7-288E-6DB7-F6EC-E685E64D821F',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D', 'selecionar as partes da norma aplicáveis à empresa, recebendo assim a certificação apenas sobre essas partes implementadas ' , 0),
(  '5D2EAED0-572C-FC70-7B17-56E80EB337EE',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D', 'realizar previamente uma análise de risco com abordagem quantitativa' , 0),
(  '697DE067-3595-1152-96E9-5963123B9DF3',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D', 'definir uma política de segurança com base no uso efetivo de um conjunto técnico de ferramentas, de reconhecida eficiência ' , 1),
(  'F84D9A29-A278-0047-3D49-D7E8B86E9354',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D', 'garantir que os gestores de segurança realizem análises críticas do SGSI em intervalos regulares' , 0),
(  '1CCE6AB6-E84F-7707-E12E-270BF75CC38C',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D', 'justificar, na declaração de aplicabilidade, o motivo da não utilização de controles listados na própria norma.' , 0),
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
(  '50974627-4F72-5DD4-456D-BB657B1C8D24',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6', 'causa overflow em representação de 8 bits em complemento a 2' , 0),
(  '55293613-0142-AE23-E063-D61D99DAC7B4',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6', 'causa overflow em representação de 16 bits em complemento a 2' , 0),
(  '158E597D-6354-C49C-777A-CCC215D243B6',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6', 'não pode ser representado em 8 bits, já que a base é 16' , 1),
(  '1A627284-C7A4-66FC-CD8D-E55665C96315',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6', 'produz um inteiro negativo em representação de 16 bits em complemento a 2' , 0),
(  '24C3D79C-9621-72D1-4CD9-2C8D21C54B0B',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6', 'produz um inteiro positivo em representação de 8 bits em complemento a 2' , 0),
(  '9E662331-102D-E4BF-F633-6D0DEDD0578B',  'BC358B5E-6D78-34C6-0468-837ECA522878', 'produz uma cópia do dado em memória ROM' , 0),
(  'A9768AC1-6E09-E71E-5AC4-B5B82A3D3FCA',  'BC358B5E-6D78-34C6-0468-837ECA522878', 'não usa a memória RAM' , 1),
(  '922B4967-50D0-8488-0858-CBEE6D72F44D',  'BC358B5E-6D78-34C6-0468-837ECA522878', 'pode acarretar perda de precisão' , 0),
(  'C8475A66-6989-78D7-576D-65A27B619961',  'BC358B5E-6D78-34C6-0468-837ECA522878', 'é tão rápido quanto o acesso a dados em memória RAM' , 0),
(  'F9D8A748-A3E8-D84F-2297-159BCC39AC4A',  'BC358B5E-6D78-34C6-0468-837ECA522878', 'é mais lento que o acesso a dados em memória RAM' , 0),
(  'BCAC3B59-7E67-DBD8-4475-7123414197CC',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C', 'minor fit' , 0),
(  'D5DC0211-E4BE-A91C-F4C2-E97370784C1A',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C', 'save fit' , 0),
(  '2A827766-1679-0FE4-5CA9-89D7A5DFF285',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C', 'best fit' , 0),
(  'EDF2B9A4-587D-9D6B-9F4E-640D3986BCC3',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C', 'first fit' , 0),
(  '8667E501-B9D2-1605-3CE5-24C95CBE7F22',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C', 'worst fit' , 0),
(  '749A23A6-06C3-6084-CEC2-2A554A3188D5',  '783A2951-A279-A225-AE16-95CBB34DC7FB', 'descrição das operações, protocolo de Internet e tipo de arquivo' , 1),
(  '48B55EDC-3C33-9D89-DCA6-BBA8AA306891',  '783A2951-A279-A225-AE16-95CBB34DC7FB', 'localização do serviço, criptografia e protocolo de comunicação' , 0),
(  '9C5854E1-AC07-3652-FE07-88C1E85C51B4',  '783A2951-A279-A225-AE16-95CBB34DC7FB', 'método de conexão, protocolo de Internet e local da implementação' , 0),
(  '651181A6-607B-CD79-8EDB-27617E438F7E',  '783A2951-A279-A225-AE16-95CBB34DC7FB', 'localização, assinatura digital e componente' , 0),
(  '7EB9A2BB-30C6-B1A9-A2E9-14DED13BAAA6',  '783A2951-A279-A225-AE16-95CBB34DC7FB', 'interface, ligação e local da implementação' , 0),
(  '94787D61-A5B3-ABBF-5DD7-C2C72E43695D',  'A84864C2-B45C-B065-BBB4-30869B3CD110', 'o syslog utiliza o protocolo de transporte UDP, o qual faz controle de fluxo' , 0),
(  'BE12195E-8985-D114-A0E5-BA45A739EDD6',  'A84864C2-B45C-B065-BBB4-30869B3CD110', 'o servidor centralizador enviará mensagens aos clientes, informando que está com a fila cheia' , 0),
(  'CA5A163D-86D1-9733-8684-E987B8A84782',  'A84864C2-B45C-B065-BBB4-30869B3CD110', 'o cliente armazenará temporariamente as mensagens até conseguir transmiti-la ao servidor centralizador' , 1),
(  '847F8D52-8BC4-8A3A-7B4B-4F8BE98303F7',  'A84864C2-B45C-B065-BBB4-30869B3CD110', 'o servidor centralizador descartará todas as mensagens que não conseguir armazenar, independentemente de sua severidade' , 0),
(  '7506B9DE-D5BF-25AC-BB94-53C49E27052E',  'A84864C2-B45C-B065-BBB4-30869B3CD110', 'o cliente descartará todas as mensagens que não conseguir transmitir ao servidor centralizador, independentemente de sua severidade ' , 0);


INSERT INTO [turma] (id,nome,professor_id)
VALUES
(  'DE4E6DF2-1842-21A6-F5DE-18BB234D3EFD','UNIRITTER-20220110-1',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '14A36DFA-5DA6-3572-1E04-8BA71BAA519C','UNP-20220110-0',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E');


INSERT INTO [matricula] (id,aluno_id,TurmaId)
VALUES
(  'E4B3F921-E313-068A-4ACB-967EE7E287E0',  'C2C93C0B-7A51-B67A-E7E7-BB8A35794681',  'DE4E6DF2-1842-21A6-F5DE-18BB234D3EFD');


INSERT INTO [avaliacao] (id, turma_id, prova_id)
VALUES 
('1F34DD28-AF77-4F0D-9C59-00810D187DDA', 'DE4E6DF2-1842-21A6-F5DE-18BB234D3EFD', '74571868-177D-B263-9965-700F2723BA15')


INSERT INTO [avaliacao_matricula] (id, avaliacao_id, matricula_id, nota)
VALUES
('1D6138BB-1F55-4C7F-85EB-5E54ECB5E645', '1F34DD28-AF77-4F0D-9C59-00810D187DDA', 'E4B3F921-E313-068A-4ACB-967EE7E287E0', 7)
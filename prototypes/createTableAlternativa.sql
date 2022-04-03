IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('alternativa'))
BEGIN;
    DROP TABLE [alternativa];
END;
GO

CREATE TABLE [alternativa] (
    [id] UNIQUEIDENTIFIER,
    [questao_id] VARCHAR(MAX) NULL,
    [text] VARCHAR(MAX) NULL,
    [eh_resposta] BIT NOT NULL,
    PRIMARY KEY ([id])
);
GO

INSERT INTO [alternativa] (id, questao_id,text, eh_resposta)
VALUES
(  '53018B7C-032A-C05D-73A3-A63DBA415241',  '23A50283-E406-EC39-347D-6D68044B2617', 'Utilizar blacklists para rejeitar e-mails de fontes conhecidas de spam' , 1),
(  '7C77E685-E833-74B7-8B01-7570C7595DAD',  '23A50283-E406-EC39-347D-6D68044B2617', 'Permitir apenas o recebimento de mensagens oriundas de remetentes autenticados em SMTP' , 0),
(  '3671A258-A8D8-AA63-1709-CC6662F9422F',  '23A50283-E406-EC39-347D-6D68044B2617', 'Utilizar filtros baseados em relatos, onde o sistema *aprende* a partir de mensagens marcadas como spam pelos usuários' , 0),
(  '6AB373B5-0687-F05F-FA84-08A907D596D9',  '23A50283-E406-EC39-347D-6D68044B2617', 'Recusar temporariamente uma mensagem e esperar por sua retransmissão, que só costuma ocorrer a partir de MTAs legítimos' , 0),
(  'C2051581-3058-49F8-9727-42A8EB5650AF',  '23A50283-E406-EC39-347D-6D68044B2617', 'Usar detecção por camadas para identificar padrões de spam, interrompendo em tempo real as mensagens indesejadas.' , 0),
(  '0524ECCA-35BB-4BBA-2A95-0DA6C3794098',  '3A6B406E-D83E-1E26-149E-1E19F268759A', 'I e II;' , 0),
(  'B82748A5-94E4-2511-A2F6-653F2070898C',  '3A6B406E-D83E-1E26-149E-1E19F268759A', 'I e III;' , 0),
(  'CF765C25-D65E-B133-79BD-9A3838952EE2',  '3A6B406E-D83E-1E26-149E-1E19F268759A', 'II e III;' , 1),
(  'CF482041-84A4-A798-79CD-6B0FC920128A',  '3A6B406E-D83E-1E26-149E-1E19F268759A', 'III;' , 0),
(  '1B585338-38C4-2CCB-FB45-EBAD1A6C152F',  '3A6B406E-D83E-1E26-149E-1E19F268759A', 'I, II e III.' , 0),
(  '284C1EB7-288E-6DB7-F6EC-E685E64D821F',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D', 'selecionar as partes da norma aplicáveis à empresa, recebendo assim a certificação apenas sobre essas partes implementadas ' , 0),
(  '5D2EAED0-572C-FC70-7B17-56E80EB337EE',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D', 'realizar previamente uma análise de risco com abordagem quantitativa' , 0),
(  '697DE067-3595-1152-96E9-5963123B9DF3',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D', 'definir uma política de segurança com base no uso efetivo de um conjunto técnico de ferramentas, de reconhecida eficiência ' , 1),
(  'F84D9A29-A278-0047-3D49-D7E8B86E9354',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D', 'garantir que os gestores de segurança realizem análises críticas do SGSI em intervalos regulares' , 0),
(  '1CCE6AB6-E84F-7707-E12E-270BF75CC38C',  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D', 'justificar, na declaração de aplicabilidade, o motivo da não utilização de controles listados na própria norma.' , 0),
(  '64436A2B-BAF9-15BE-3AEA-B3B1B19D1A28',  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2', 'CBC (Cipher-block chaining)' , 0),
(  '7A66C8B9-2AE4-23E8-A54E-5638BD0D7277',  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2', 'ECB (Electronic Code Book)' , 1),
(  '46591DB4-5DA2-A6B9-895D-0BAABB3DB817',  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2', 'CFB (Cipher feedback)' , 0),
(  'EB1A361C-4204-6917-9816-70438B914EA3',  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2', 'OFB (Output feedback)' , 0),
(  'DD534C8F-C643-64C2-8463-5F8B47E49126',  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2', 'ICM (Integer Counter Mode)' , 0),
(  'F7DEEC72-DC50-7C29-8D65-7B6F8DCB2638',  '2F936AE7-6B77-3ED8-CA4A-77945F856612', '1000000000000010' , 1),
(  'CE457DBD-E5F5-EE55-FD50-9C38918EF9A3',  '2F936AE7-6B77-3ED8-CA4A-77945F856612', '1111111111111110' , 0),
(  'E39E3A43-E7AC-5D36-7C43-715056415F8C',  '2F936AE7-6B77-3ED8-CA4A-77945F856612', '0111111111111110' , 0),
(  'E1CF5813-1D76-E3E2-AF8B-0801F1D8FB23',  '2F936AE7-6B77-3ED8-CA4A-77945F856612', '1010101010101010' , 0),
(  'C3613C06-176F-CB2E-6276-B99D6086F513',  '2F936AE7-6B77-3ED8-CA4A-77945F856612', '0101010101010101' , 0),
(  '50974627-4F72-5DD4-456D-BB657B1C8D24',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6', 'causa overflow em representação de 8 bits em complemento a 2' , 0),
(  '55293613-0142-AE23-E063-D61D99DAC7B4',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6', 'causa overflow em representação de 16 bits em complemento a 2' , 0),
(  '158E597D-6354-C49C-777A-CCC215D243B6',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6', 'não pode ser representado em 8 bits, já que a base é 16' , 1),
(  '1A627284-C7A4-66FC-CD8D-E55665C96315',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6', 'produz um inteiro negativo em representação de 16 bits em complemento a 2' , 0),
(  '24C3D79C-9621-72D1-4CD9-2C8D21C54B0B',  'C8D6156D-7476-5647-E7C3-8DE0D22591D6', 'produz um inteiro positivo em representação de 8 bits em complemento a 2' , 0),
(  '9E662331-102D-E4BF-F633-6D0DEDD0578B',  'BC358B5E-6D78-34C6-0468-837ECA522878', 'produz uma cópia do dado em memória ROM' , 0),
(  'A9768AC1-6E09-E71E-5AC4-B5B82A3D3FCA',  'BC358B5E-6D78-34C6-0468-837ECA522878', 'não usa a memória RAM' , 1),
(  '922B4967-50D0-8488-0858-CBEE6D72F44D',  'BC358B5E-6D78-34C6-0468-837ECA522878', 'pode acarretar perda de precisão' , 0),
(  'C8475A66-6989-78D7-576D-65A27B619961',  'BC358B5E-6D78-34C6-0468-837ECA522878', 'é tão rápido quanto o acesso a dados em memória RAM' , 0),
(  'F9D8A748-A3E8-D84F-2297-159BCC39AC4A',  'BC358B5E-6D78-34C6-0468-837ECA522878', 'é mais lento que o acesso a dados em memória RAM' , 0),
(  'BCAC3B59-7E67-DBD8-4475-7123414197CC',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C', 'minor fit' , 0),
(  'D5DC0211-E4BE-A91C-F4C2-E97370784C1A',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C', 'save fit' , 0),
(  '2A827766-1679-0FE4-5CA9-89D7A5DFF285',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C', 'best fit' , 0),
(  'EDF2B9A4-587D-9D6B-9F4E-640D3986BCC3',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C', 'first fit' , 0),
(  '8667E501-B9D2-1605-3CE5-24C95CBE7F22',  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C', 'worst fit' , 0),
(  '749A23A6-06C3-6084-CEC2-2A554A3188D5',  '783A2951-A279-A225-AE16-95CBB34DC7FB', 'descrição das operações, protocolo de Internet e tipo de arquivo' , 1),
(  '48B55EDC-3C33-9D89-DCA6-BBA8AA306891',  '783A2951-A279-A225-AE16-95CBB34DC7FB', 'localização do serviço, criptografia e protocolo de comunicação' , 0),
(  '9C5854E1-AC07-3652-FE07-88C1E85C51B4',  '783A2951-A279-A225-AE16-95CBB34DC7FB', 'método de conexão, protocolo de Internet e local da implementação' , 0),
(  '651181A6-607B-CD79-8EDB-27617E438F7E',  '783A2951-A279-A225-AE16-95CBB34DC7FB', 'localização, assinatura digital e componente' , 0),
(  '7EB9A2BB-30C6-B1A9-A2E9-14DED13BAAA6',  '783A2951-A279-A225-AE16-95CBB34DC7FB', 'interface, ligação e local da implementação' , 0),
(  '94787D61-A5B3-ABBF-5DD7-C2C72E43695D',  'A84864C2-B45C-B065-BBB4-30869B3CD110', 'o syslog utiliza o protocolo de transporte UDP, o qual faz controle de fluxo' , 0),
(  'BE12195E-8985-D114-A0E5-BA45A739EDD6',  'A84864C2-B45C-B065-BBB4-30869B3CD110', 'o servidor centralizador enviará mensagens aos clientes, informando que está com a fila cheia' , 0),
(  'CA5A163D-86D1-9733-8684-E987B8A84782',  'A84864C2-B45C-B065-BBB4-30869B3CD110', 'o cliente armazenará temporariamente as mensagens até conseguir transmiti-la ao servidor centralizador' , 1),
(  '847F8D52-8BC4-8A3A-7B4B-4F8BE98303F7',  'A84864C2-B45C-B065-BBB4-30869B3CD110', 'o servidor centralizador descartará todas as mensagens que não conseguir armazenar, independentemente de sua severidade' , 0),
(  '7506B9DE-D5BF-25AC-BB94-53C49E27052E',  'A84864C2-B45C-B065-BBB4-30869B3CD110', 'o cliente descartará todas as mensagens que não conseguir transmitir ao servidor centralizador, independentemente de sua severidade ' , 0);

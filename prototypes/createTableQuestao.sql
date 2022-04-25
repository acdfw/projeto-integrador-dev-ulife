IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('questao'))
BEGIN;
    DROP TABLE [questao];
END;
GO

CREATE TABLE [questao] (
    [id] UNIQUEIDENTIFIER,
    [enunciado] VARCHAR(MAX) NULL,
    [professor_id] VARCHAR(MAX) NULL,
    PRIMARY KEY ([id])
);
GO

INSERT INTO [questao] (id,enunciado,professor_id)
VALUES
(  '23A50283-E406-EC39-347D-6D68044B2617','Procurando minimizar o número de spams que uma empresa recebe, os administradores de rede resolveram implementar a técnica de greylist, que consiste em: ', 'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '3A6B406E-D83E-1E26-149E-1E19F268759A','Em relação a assinaturas digitais, analise as afirmativas a seguir: I. Certificado categoria S2 é o certificado usado para assinatura digital, com tamanho mínimo de 1024 bits, gerado por software e armazenado em um token. II. A verificação da assinatura digital de um documento eletrônico é realizada através da chave pública do remetente do documento. III. O DSA, algoritmo usado para assinaturas digitais, possui uma variante que utiliza curvas elípticas. Está correto somente o que se afirma em:' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D','Uma empresa deseja ser certificada na implementação da norma ISO 27001. Para tal, ela deve seguir com rigor o que preconiza a norma, como por exemplo:' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2','Para criptografar mensagens de tamanho arbitrário, existem vários modos de operação especificando como a criptografia será aplicada. Um desses modos é frágil em termos de segurança, pois não oculta o padrão de dados da mensagem original, mantendo-o na mensagem codificada. Esse modo de operação, menos seguro, é o:',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '2F936AE7-6B77-3ED8-CA4A-77945F856612','O número inteiro –2 (menos dois) tem a seguinte representação em 16 bits, usando complemento a 2:' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  'C8D6156D-7476-5647-E7C3-8DE0D22591D6','O resultado da multiplicação entre os inteiros 7F16 x 1216, ambos representados em complemento a 2 na base 16' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  'BC358B5E-6D78-34C6-0468-837ECA522878','O acesso a dados em registradores internos da Unidade Central de Processamento (UCP):' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C','A estratégia de alocação de memória que busca o menor espaço livre suficiente para satisfazer cada requisição denomina-se:' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '783A2951-A279-A225-AE16-95CBB34DC7FB','Segundo Ian Sommerville, as arquiteturas orientadas a serviços (SOA) são uma forma de desenvolvimento de sistemas distribuídos em que os componentes de sistema são serviços autônomos, executando em computadores geograficamente distribuídos. Para que  acesso a esses serviços ocorra, são utilizados alguns padrões, dentre os quais estão o SOAP, WSDL e WS-BPEL. A linguagem WSDL é baseada em XML e tem como função especificar um serviço (web service) considerando os seguintes aspectos:',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  'A84864C2-B45C-B065-BBB4-30869B3CD110','Cristiano implementou o syslog nos servidores Linux que administra com o intuito de enviar todas as mensagens de log para um único servidor, que centralizará todos os logs da rede. Cristiano não está preocupado com a quantidade de mensagens de log  transmitidas entre os clientes e o servidor centralizador de log, pois:',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),

('CDAE91B1-D657-7999-3AF0-98EDC9AB354A','¿Cómo podemos traducir la palabra adicción en el texto?','78E82B34-238C-AB34-A05E-53CC45D89754'),
('4D7AC40A-CFDE-15D4-FEA3-09B829B447C2','Qué hora es? 1:45.','78E82B34-238C-AB34-A05E-53CC45D89754'),
('DFAADCBE-919B-6E57-B4BC-B7E73E8AC570','Elige la alternativa CORRECTA con la forma verbal adecuada de Presente de Indicativo','78E82B34-238C-AB34-A05E-53CC45D89754'),
('4AFD3809-5274-DEA3-EC85-19498BBCC7F3','Señala la forma CORRECTA de los participios de los verbos: morir, decir, hacer, ver, poner, freír.','78E82B34-238C-AB34-A05E-53CC45D89754'),
('7C41465A-AE84-DAB9-814C-412794FEE95E','Lea y marque la alternativa CORRECTA.','78E82B34-238C-AB34-A05E-53CC45D89754'),
('4D8EEA17-1CBC-8121-5B01-A788D254187C','La fecha 06 / 02 / 1978 está CORRECTAMENTE escrita.','78E82B34-238C-AB34-A05E-53CC45D89754'),
('1234B457-DADD-1B2B-3EBC-5CFCDA392261','Los verbos disfrutaba, comenzaron y habían puesto están conjugados en respectivamente','78E82B34-238C-AB34-A05E-53CC45D89754'),
('562AA2CD-4A57-6E72-A760-BBC26C8C1A3D','Elige la respuesta adequada.','78E82B34-238C-AB34-A05E-53CC45D89754'),
('136A733D-5C33-2935-C859-DDA9AD25B0BB','Elige la única alternativa que no presenta ERROR','78E82B34-238C-AB34-A05E-53CC45D89754'),
('61240F89-7CE3-CC4A-8912-BFB6E5A785F8','Las palabras son acentuadas diferentemente según la sílaba tónica. Marca la única alternativa que clasifica las palabras abajo CORRECTAMENTE: Difícil, Fórmula, Disposición, Mayoría, así','78E82B34-238C-AB34-A05E-53CC45D89754'),

('9748FA7B-323D-A1DA-56C1-58F7FC929E98','Todos sabem que manipular alimentos em um ambiente sujo é uma forma comum de contaminá-los. Além da higiene com os alimentos, utensílios e equipamentos, é necessária uma atenção especial na higiene do espaço onde se preparam os alimentos e refeições. Em relação à higiene da cozinha, a afirmativa correta é:','E9763836-4FCE-5D5E-EEB7-5E6A4D9FDB9B'),
('FE836E56-28FE-AB43-28E8-B16EA1AEAB8A','A panela de pressão é uma grande aliada das donas de casa e de todos os que fazem do ato de cozinhar uma profissão. Por garantir um cozimento rápido, representa uma economia de tempo e gás, porém seu uso requer cuidados especiais, pois o manuseio inadequado representa riscos de acidentes. Assinale a alternativa que indica uma orientação correta.','E9763836-4FCE-5D5E-EEB7-5E6A4D9FDB9B'),
('4332CB39-3EED-20EA-57F5-666B34BF38AC','Sobre o uso de Equipamento de Proteção Individual (EPI), é correto que se afirma em:','E9763836-4FCE-5D5E-EEB7-5E6A4D9FDB9B'),
('1840E603-8086-5BDF-B489-9A3CEE4BD2BE','Em relação ao preparo de suco de frutas, assinale a alternativa correta.','E9763836-4FCE-5D5E-EEB7-5E6A4D9FDB9B'),
('F66ED855-1232-FA15-49E2-55422B1C1458','Quanto à higiene de utensílios, é correto:','E9763836-4FCE-5D5E-EEB7-5E6A4D9FDB9B'),
('268535BE-F755-16DE-EA73-6831F57D9E7E','Como devem se apresentar as embalagens dos enlatados?','E9763836-4FCE-5D5E-EEB7-5E6A4D9FDB9B'),
('9B5C5862-5298-2AAE-F9D1-14D69CB360C6','Tendo em vista as normas higiênicas e de segurança, que alternativa abaixo é a mais adequada em relação à utilização dos equipamentos de proteção individual em uma cozinha?','E9763836-4FCE-5D5E-EEB7-5E6A4D9FDB9B'),
('02A103C2-BCE2-49C6-4D71-1124B1DAA94A','No armazenamento de produtos perecíveis, sob refrigeração, deve-se manter: ','E9763836-4FCE-5D5E-EEB7-5E6A4D9FDB9B'),
('FBCC0DA2-356D-8B97-856D-64A887C0FAFD','Pode-se afirmar que equipamento de proteção individual é: ','E9763836-4FCE-5D5E-EEB7-5E6A4D9FDB9B'),
('9EACFA04-965D-AA65-D213-E8B756E67191','Sobre a ética profissional do Cozinheiro, marque o INCORRETO:','E9763836-4FCE-5D5E-EEB7-5E6A4D9FDB9B');


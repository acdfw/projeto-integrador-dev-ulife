IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('professor'))
BEGIN;
    DROP TABLE [professor];
END;
GO

CREATE TABLE [professor] (
    [id] UNIQUEIDENTIFIER,
    [usuario_ID] UNIQUEIDENTIFIER,
    PRIMARY KEY ([id])
);
GO

INSERT INTO [professor] (id,usuario_ID)
VALUES
(  'EC44538B-C8D3-8842-D336-8C4E371B7B9E',  '6C816AE5-8669-A80E-73A7-01F487478338'),	
(  '66855EC2-1776-6BBE-8441-9DA112EC1B56',  '75EE5E5D-E4B5-1A9B-85C1-FA39D52E77BF'),	
(  '4D610B85-5640-19C4-5526-D4557E36FB14',  '19585473-9B43-413A-B445-5A2A9C5575E7'),	
(  '1727C416-2834-903C-65B1-1D584F0337A2',  '889D6AC5-38E0-AAC2-85DD-4E9A96872EF8'),	
(  '8DB49931-51A7-F228-0FD2-5EC3597A10D5',  '5ACB0A87-8BE9-A585-EBC4-ACCEA6EC1359'),	
(  '7E5C98E4-C293-E47C-2817-DB75A4888E9E',  '136CD786-67DB-9281-2FAD-7C1B72CDF1B5'),	
(  'E9763836-4FCE-5D5E-EEB7-5E6A4D9FDB9B',  '2AA7E84A-EF98-8854-D6EC-8175875A7E10'),	
(  '566FEEFA-35BD-65A8-5296-01F70EA4A172',  'C3BCA7E4-45E2-2F3E-3B09-874BADD889EF'),	
(  '33AAEB0E-DDE0-1B95-D31C-53DD775AADD1',  '4A308B9C-3C21-5CA8-EB8D-ADAF125850E9'),	
(  '78E82B34-238C-AB34-A05E-53CC45D89754',  '9AA29D8A-6B7C-1FB1-E105-33E2E338C72E'),	
(  'CAE28A30-9659-482E-E86C-AD549D67A43E',  'B832169A-641C-4F46-EAA5-644854FF461F'),	
(  'D185268E-794B-9172-5E67-3A524586DD7E',  '8B8B4AA9-DB7D-7E79-8922-2D7C46EC9A71'),	
(  'EF5D521C-A31A-CE83-084B-EC4C7BEA0FF8',  'F1195E61-9744-AD55-2169-948355875369'),	
(  '8EBE8E8C-6F65-8BE3-D6C2-E24F4CEC5DEA',  '4D1D53CE-8CB1-8BE8-9C9A-424E4832299A'),	
(  '9D948B1A-A2C9-BAD8-C1BB-EE7A47EBA336',  '175F6DDF-B86A-74EE-E923-9259960CFA15'),	
(  'E09D9ABE-1FC8-5537-37D2-77F7A9637672',  '45B6DAED-8CAF-9B27-6D54-DE73BC21A55D'),	
(  'EABF3C43-E9BA-9C73-1146-B70322A2D876',  'ABD3106B-6A89-BBC7-C89B-2B690173AE17'),	
(  '78783D5C-428D-7355-BCD7-8599F1635234',  '61C16633-8CE2-3323-5F37-0762E139AB8E'),	
(  'D2C0EF95-E164-8DCC-AAE4-21AB2475F9DA',  '5C798DE5-DE65-6563-5313-E20A04CCD7E1'),	
(  '7C6A7F17-99E6-2CAC-DCC2-33D4EE449396',  '48238B63-C512-B848-EE26-63059F67AA58'),	
(  '4B318DAA-533E-E59F-7384-DF5DB598E83A',  '7D01B298-DBC8-C4E1-1074-3A1C7565D403'),	
(  '755829C2-1B9D-40E9-4BD5-C9F5E27C2DE6',  'EF96E3A7-524A-43C5-352B-11EE337D2298'),	
(  '8818DF81-1776-796D-7FA4-E11EB3E2101B',  '58CFCD8F-4E62-9234-A2FA-AE914B3CDD5D'),	
(  '37C58B33-E7B6-1B20-CE38-B3B3DB480A49',  'DDC209D8-7294-582D-5C1C-30C7A1EEC88A'),	
(  '4A98D245-CC45-C3AE-E6AA-3F4E8C71DD7A',  'D1774057-C425-E45A-DF5E-95B590E2B3C4'),	
(  '4B01FB54-82B3-D627-F4EC-5379D4BDEE2C',  '3B64CC11-7137-1B1D-77B7-EA00F35AE445'),	
(  'A6B845F5-433E-2520-0A0E-6B1391766F65',  '9D711546-A214-CF23-93E0-7E4A8C7D42C3'),	
(  'CEF7DED1-5102-3EB8-5596-7381BB424D16',  'D2352447-8F1D-1FFE-56FD-3B55F71CC7B9'),	
(  '6D222495-9BE7-FCB4-28C8-F64AA32E797B',  'B34D429B-39CA-95B2-056A-0E66871EAD92'),	
(  'BA448D1C-ADD3-773D-B63A-9707CC519274',  'C61D6350-D2F0-C38D-8142-61741925AA9E'),	
(  '6ABEDFAD-7B83-2BEB-A61A-A677D576184A',  '271D4443-44DD-D375-D598-D63458C71484'),	
(  '1DD29B47-E4B8-A3BF-7A1E-39F42995744A',  'EF796591-EE15-5331-8BCB-76C88D777641'),	
(  '9A57CD6E-3573-65B9-CC58-6F1D4F298A33',  'FE7819DF-6D4A-E3BA-22BC-C38FEDBAE6A2'),	
(  'ACA18B27-717E-A8EC-56D2-CA65588CF0FC',  '5562B041-F381-2685-9787-642852756571'),	
(  '33D34759-DEE1-DE37-F65B-F444A5945277',  'E33BFAB2-9989-DDBD-C256-6CB418A642AB'),	
(  '7504BB75-2C6D-9253-A905-179E718F74C9',  '89E44403-B978-2EDA-CB94-B892F29812EA'),	
(  '29EAB7E2-E3FD-3921-8AD8-2820A80A3939',  '818D34AC-90AB-C6BA-D673-5B0DDC326A55'),	
(  '64D93131-A07E-FB18-924C-B1B5F968572B',  'D77D61C7-CCA1-48EE-B847-75CC62747314'),	
(  '7370778D-86AC-6405-E5B5-0695E9611642',  'DEA34E66-C917-51D1-4E79-9E9D437CEA5D'),	
(  '27E366FF-3A7C-C2BE-19B5-86C28F989C8A',  '1614CD2C-EC57-1672-FC6C-BE6C183C37C4'),	
(  'B648C5C5-7889-DC4B-7CF9-C7A2065D5610',  '7F7ED756-CA52-B78F-59E8-CA907696115E'),	
(  'B6791642-8EEC-D974-491E-9D7C5B8B17E6',  'B0DBBCE6-DE02-7A70-1D65-DDA36EE4387B'),	
(  '611CEC21-C45F-D5D3-2B39-B0E2E4360503',  'DF8D9AA3-E193-BBCB-2B16-BA7D565C1491'),	
(  'D7C30251-B5D0-E164-B325-9F603BD57B7D',  '0B7555C9-EDDA-2BAF-4A00-87BB1EB9C3A9'),	
(  'BBD2FC72-C4F5-4035-FEE8-5BD53E369299',  '05F5AF49-C430-6933-1639-0234EDB37594'),	
(  'E22766C6-B350-3AD8-C253-1E24A5BD239D',  '8CD901B4-BD85-7B8F-9939-5E67D3688987'),	
(  '216EB739-2B43-CDB0-CFA4-30F9B46274D6',  '132AD87D-7A37-6DD8-C659-0453E4FD9C9C'),	
(  'DE4ABB1C-5BCD-B699-3E5B-A2106ED952F2',  'ACA4BC1D-F84F-FA3E-4149-7D120242523A'),	
(  '15E7D9C7-D3BF-E4E3-4938-B2E613569872',  'D69B9AA0-C3D5-A434-AE49-899EDA32359E'),	
(  '49354D5B-18D7-DAA9-90DE-93261DC21BE1',  '8EA2680B-2965-49CF-3226-7FCCA81443F2');

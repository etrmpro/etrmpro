USE emdm;
GO

insert into [power].[ISO] (ISOId, Name) values (1, 'ERCOT');
insert into [power].[ISO] (ISOId, Name) values (2, 'PJM');

insert into [power].[PricingPointType] (PricingPointTypeId, Name) values (1, 'Hub');
insert into [power].[PricingPointType] (PricingPointTypeId, Name) values (2, 'Zone');
insert into [power].[PricingPointType] (PricingPointTypeId, Name) values (3, 'Node');
insert into [power].[PricingPointType] (PricingPointTypeId, Name) values (4, 'Generator');
insert into [power].[PricingPointType] (PricingPointTypeId, Name) values (5, 'Intertie');
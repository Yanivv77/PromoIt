CREATE DEFINER=`root`@`%` PROCEDURE `CreateOrder_procedure`(ActivistUserID int,ProductID int)
BEGIN
INSERT INTO `PromoIt`.`Order`
(
`ActivistUserID`,
`ProductID`)
VALUES
(ActivistUserID , ProductID);

END
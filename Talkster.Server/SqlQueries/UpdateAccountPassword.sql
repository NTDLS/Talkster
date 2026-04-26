UPDATE
	Account
SET
	PasswordHash = @PasswordHash
WHERE
	Id = @Id

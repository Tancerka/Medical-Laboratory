ALTER TABLE Users
ALTER COLUMN Password VARCHAR(255) NOT NULL

UPDATE Users
SET Password = '$PBKDF2$100000$SHA256$/4LYqx5+lPmH+fBRi8vwIhgVZD/IwdgODLVfEUspdsYuizGpM+F+RI7KRqM0MjUh'
WHERE Login = 'admin';

UPDATE Users
SET Password = '$PBKDF2$100000$SHA256$pMq1Vk+ivGM+4GjvswCyBf97devdXCM1fpJqTD5Lf0jUR/cU6yzPGh55AwHswPux'
WHERE Login = 'nurse';

UPDATE Users
SET Password = '$PBKDF2$100000$SHA256$IF2KXHCQowLxucKHq0U97OviDJcYPMy+661KnaROGGT2OvtaCMlBa8jPSVLn+Z+6'
WHERE Login = 'analyst';

UPDATE Users
SET Password = '$PBKDF2$100000$SHA256$5IM7DhbcYhPkyHz9KjzQaDubz+9p17/ZWn9jZ/2/yBNBmq8oLm48uBFZ3qP3gY0W'
WHERE Login = 'patient';
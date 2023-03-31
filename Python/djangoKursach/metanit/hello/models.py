

from django.db import models

class Staff(models.Model):
    Name = models.CharField(max_length=25)
    Surname= models.CharField(max_length=25)
    Patronymic= models.CharField(max_length=25)
    Telephone= models.CharField(max_length=11)
    Role= models.CharField(max_length=24)

class Orders(models.Model):
    Client = models.CharField(max_length=25)
    Date = models.CharField(max_length=25)
    Price= models.IntegerField()
    Car = models.CharField(max_length=45)

# Generated by Django 2.1.15 on 2022-11-08 11:01

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('hello', '0001_initial'),
    ]

    operations = [
        migrations.AlterField(
            model_name='orders',
            name='Car',
            field=models.CharField(max_length=45),
        ),
        migrations.AlterField(
            model_name='staff',
            name='Role',
            field=models.CharField(max_length=24),
        ),
    ]
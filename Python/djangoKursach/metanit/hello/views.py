from django.shortcuts import render
from .models import Orders, Staff
from django.http import HttpResponseRedirect, HttpResponseNotFound


# получение данных из бд
def index(request):
    products = Orders.objects.all()
    staff = Staff.objects.all()
    return render(request, "index.html", {"products": products,"staff": staff})


# добавление данных из бд
def create(request):


    # если запрос POST, сохраняем данные
    if request.method == "POST":
        product = Orders()
        product.Client= request.POST.get("Client")
        product.Price = request.POST.get("Price")
        product.Date=request.POST.get("Date")
        product.Car=request.POST.get("Car")
        product.save()
        return HttpResponseRedirect("/")
    # передаем данные в шаблон

    return render(request, "create.html")


# изменение данных в бд
def edit(request, id):
    try:
        product = Orders.objects.get(id=id)

        if request.method == "POST":
            product.Client = request.POST.get("Client")
            product.Price = request.POST.get("Price")
            product.Date = request.POST.get("Date")
            product.Car = request.POST.get("Car")
            product.save()
            return HttpResponseRedirect("/")
        else:

            return render(request, "edit.html", {"product": product})
    except Orders.DoesNotExist:
        return HttpResponseNotFound("<h2>Product not found</h2>")


# удаление данных из бд
def delete(request, id):
    try:
        product = Orders.objects.get(id=id)
        product.delete()
        return HttpResponseRedirect("/")
    except Orders.DoesNotExist:
        return HttpResponseNotFound("<h2>Product not found</h2>")

def create2(request):

    # если запрос POST, сохраняем данные
    if request.method == "POST":
        product = Staff()
        product.Name= request.POST.get("Name")
        product.Surname = request.POST.get("Surname")
        product.Patronymic=request.POST.get("Patronymic")
        product.Telephone=request.POST.get("Telephone")
        product.Role = request.POST.get("Role")
        product.save()
        return HttpResponseRedirect("/")
    # передаем данные в шаблон

    return render(request, "create2.html")


# изменение данных в бд
def edit2(request, id):
    try:
        product = Staff.objects.get(id=id)

        if request.method == "POST":
            product.Name = request.POST.get("Name")
            product.Surname = request.POST.get("Surname")
            product.Patronymic = request.POST.get("Patronymic")
            product.Telephone = request.POST.get("Telephone")
            product.Role = request.POST.get("Role")
            product.save()
            return HttpResponseRedirect("/")
        else:

            return render(request, "edit2.html", {"product": product})
    except Orders.DoesNotExist:
        return HttpResponseNotFound("<h2>Product not found</h2>")


# удаление данных из бд
def delete2(request, id):
    try:
        product = Staff.objects.get(id=id)
        product.delete()
        return HttpResponseRedirect("/")
    except Orders.DoesNotExist:
        return HttpResponseNotFound("<h2>Product not found</h2>")


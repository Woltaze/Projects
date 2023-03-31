from django.urls import path
from hello import views

urlpatterns = [
    path("", views.index),
    path("create/", views.create),
    path("edit/<int:id>/", views.edit),
    path("delete/<int:id>/", views.delete),
    path("create2/",views.create2),
    path("edit2/<int:id>/",views.edit2),
    path("delete2/<int:id>/",views.delete2),
]
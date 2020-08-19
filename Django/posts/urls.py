from django.urls import path
from . import views

urlpatterns = [
    path('', views.index, name='posts-home'),
    path('details/', views.details, name='posts-details'),
]

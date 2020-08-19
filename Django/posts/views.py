from django.shortcuts import render
from .models import Post
posts = [
    {
        'title': 'Post 1',
        'body': 'Blog Post 1',
        'created_at': 'Aug 06,2020'
    },
    {
        'title': 'Post 2',
        'body': 'Blog Post 2',
        'created_at': 'Aug 06,2020'
    }
]


def index(request):
    return render(request, 'posts/index.html', {"posts": Post.objects.all(), "title": "title"})


def details(request, post_id):

    return render(request, 'posts/details.html', {"title": "title"})

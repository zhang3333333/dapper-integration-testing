﻿using System;
using System.Collections.Generic;
using System.Linq;

using Dapper;

using DapperTesting.Core.Model;

namespace DapperTesting.Core.Data
{
    public class DapperPostRepository : DapperRepositoryBase, IPostRepository
    {
        public DapperPostRepository(IConnectionFactory connectionFactory, string connectionStringName) : base(connectionFactory, connectionStringName)
        {
        }

        public void Create(Post post)
        {
            throw new NotImplementedException();
        }

        public void AddDetails(int postId, PostDetails details)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int postId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDetails(int detailsId)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetPostsForUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Post Get(int id)
        {
            const string sql = "SELECT * FROM [Posts] WHERE [Id] = @postId";

            var post = Fetch(c => c.Query<Post>(sql, new { postId = id })).SingleOrDefault();

            return post;
        }

        public PostDetails GetDetails(int postId, int sequence)
        {
            throw new NotImplementedException();
        }

        public bool Update(Post post)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDetails(PostDetails details)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieverCore.Models.Common
{
    public class Result
    {
        public bool IsSuccess { get; }
        public Exception Exception { get; }

        private Result(bool isSuccess, Exception e = null)
        {
            IsSuccess = isSuccess;
            Exception = e;
        }

        public static Result Ok()
        {
            return new Result(true);
        }

        public static Result Fail(Exception e = null)
        {
            return new Result(false, e);
        }
    }

    public class Result<T>
    {
        public bool IsSuccess { get; }
        public Exception Exception { get; }
        public T Output { get; }

        private Result(bool isSuccess, T output, Exception e = null)
        {
            IsSuccess = isSuccess;
            Output = output;
            Exception = e;
        }

        public static Result<T> Ok(T value)
        {
            return new Result<T>(true, value);
        }

        public static Result<T> Fail(Exception e = null)
        {
            return new Result<T>(false, default(T), e);
        }

        public static Result<T> Fail(string message)
        {
            return new Result<T>(false, default(T), new Exception(message));
        }
    }
}

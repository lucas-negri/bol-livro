using System.Runtime.Serialization;

namespace bolte.Services
{
	[Serializable]
	internal class integrityException : Exception
	{
		public integrityException()
		{
		}

		public integrityException(string? message) : base(message)
		{
		}

		public integrityException(string? message, Exception? innerException) : base(message, innerException)
		{
		}

		protected integrityException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
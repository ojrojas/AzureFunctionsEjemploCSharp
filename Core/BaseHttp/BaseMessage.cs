using System;

namespace Core.BaseHttp
{
    /// <summary>
    /// BaseMessage implement correlation requests.
    /// </summary>
    /// <author>Oscar Julian Rojas</author>
    /// <date>15/08/2021</date>
    public abstract class BaseMessage
    {
        /// <summary>
        /// Correlation protected 
        /// </summary>
        protected Guid _correlation = Guid.NewGuid();
        /// <summary>
        /// CorrelationId 
        /// </summary>
        /// <returns>Correlation guid.</returns>
        public Guid CorrelationId => _correlation;
    }
}
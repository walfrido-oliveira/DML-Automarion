namespace Walfrido.DML.Automation.Model
{
    public abstract  class Types
    {
        public enum Values
        {
            TINYINT = 1,
            SMALLINT,
            MEDIUMINT,
            INT,
            BIGINT,
            DECIMAL,
            FLOAT,
            DOUBLE,
            BIT,
            CHAR,
            VARCHAR,
            BINARY,
            VARBINARY,
            BLOB,
            TINYBLOB,
            TINYTEXT,
            TEXT,
            LONGTEXT,
            ENUM,
            SET,
            DATE,
            DATETIME,
            TIME
        };
        public enum DML
        {
            INSERT =1,
            UPDATE,
            DELETE,
            SELECT
        };
        public enum OPERATOR
        {
            EQUAL = 1,
            NOT_EQUAL,
            GREATER_THEN,
            LESS_THAN,
            GREATER_THAN_OR_EQUAL,
            LESS_THAN_OR_EQUAL,
            BETWEEN,
            LIKE,
            IN
        };
        public enum LOGICAL_OPERATOR
        {
            AND = 1,
            OR
        };
        public static string GetOperator(OPERATOR op)
        {
            switch (op)
            {
                case OPERATOR.EQUAL:
                    return  "=";
                case OPERATOR.NOT_EQUAL:
                    return  "<>";
                case OPERATOR.GREATER_THEN:
                    return  ">";
                case OPERATOR.LESS_THAN:
                    return  "<";
                case OPERATOR.GREATER_THAN_OR_EQUAL:
                    return  ">=";
                case OPERATOR.LESS_THAN_OR_EQUAL:
                    return "<=";
                case OPERATOR.BETWEEN:
                    return "BETWENN";
                case OPERATOR.LIKE:
                    return "LIKE";
                case OPERATOR.IN:
                    return "IN";
                default:
                    return "NULL";
            }
        }
    }
}

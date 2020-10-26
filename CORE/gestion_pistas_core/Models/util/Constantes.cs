using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.util
{
    public class Constantes
    {
        public static String GLOBAL_APP_NAME = "GESTION-PISTA";

        public static String FILENAME_GLOBAL_PROPS = "app-config.xml";

        public static String ERROR_CODE_CREATE = "001";
        public static String ERROR_CODE_READ = "002";
        public static String ERROR_CODE_UPDATE = "003";
        public static String ERROR_CODE_DELETE = "004";
        public static String ERROR_CODE_CUSTOM = "005";
        public static String ERROR_CODE_FATAL = "006";

        public static String DEFAULT_PAGING_PROPS = "paging.defaultpagesize";
        public static int DEFAULT_PAGING = 15;
        public static int NO_PAGING = 500;

        public static String PAGINADO = "Y";
        public static String SORT_DIRECTION_ASC = "asc";

        public static String DATE_FORMAT_DATABASE = "dd/MM/yyyy";

        public static String NUMBER_AS_STRING_FORMAT = "#,###,##0.00";
        public static char NUMBER_AS_STRING_DECIMAL_SEPARATOR = '.';
        public static char NUMBER_AS_STRING_GROUP_SEPARATOR = ',';

        public static String FORMATO_FECHA_CORTA = "yyyy-MM-dd";
        public static String FORMATO_FECHA_LARGA = "yyyy-MM-dd HH:mm:ss SSS";
        public static String FORMATO_FECHA_COMPLETA = "EEEE, d MMM yyyy HH:mm:ss";
        public static String FORMATO_FECHA_MES_CENTURIA = "MM/yyyy";

        /**
         * PARAMETROS WEB Y HTTPSESSION
         */

        public static String FILE_UPLOAD_SESSION_ATTRIB = "fileUploadSession";
        public static String USER_SESSION_ATTRIB = "user";
        public static String TOKEN_SESSION_ATTRIB = "token";
        public static String TEMPORAL_TOKEN_SESSION_ATTRIB = "temporalToken";
        public static String USER_NAME_SESSION_ATTRIB = "userName";
        public static String USER_IDENTITY_SESSION_ATTRIB = "identificador";
        public static String CARGO_SESSION_ATTRIB = "cargo";
        public static String ROL_SESSION_ATTRIB = "rol";
        public static String ROL_NAME_SESSION_ATTRIB = "rolName";
        public static String COMPANY_NAME_SESSION_ATTRIB = "companyName";
        public static String COMPANY_ID_SESSION_ATTRIB = "companyId";
        public static String COMPANY_SESSION_ATTRIB = "company";
        public static String COMPANY_IDENTIFICADOR_DEFAULT_SESSION_ATTRIB = "9999999999001";
        public static String PNG_FILE_EXTENSION = ".png";
        public static String PDF_FILE_EXTENSION = ".pdf";
        public static String XML_FILE_EXTENSION = ".xml";
        public static String PROPERTIES_FILE_EXTENSION = ".properties";
        public static String PDF_FILE_TYPE_EXTENSION = "PDF";
        public static String XML_FILE_TYPE_EXTENSION = "XML";
        public static String JASPER_FILE_EXTENSION = ".jasper";



        public static String EJB_SERVICE_SECURITY_PROP = "ejb.service.security";
        public static String FIRST_LOGIN_SECURITY_PROP = "security.key.firstLogin";



        /**
         * DATOS WEB TOKEN
         */
        public static String CRYPTO_JWT = "segurossucre.2018";
        public static String ISSUER_JWT = "www.relative-engine.com";
        public static long TTL_JWT = 50000;
        public static String KEYHEADER_JWT = "relative";
        public static String KEYHEADER_FIRST_LOGIN_JWT = "Login";

        /**
         * MENSAJES EXCEPCIONES, PARAMETROS JPS
         */
        public static String MSG_CON_ERROR = " con error ";
        public static String MSG_ERROR_BUSQUEDA = "ERROR EN LA BUSQUEDA DE ";
        public static String MSG_ERROR_EJECUCION = "ERROR EN EJECUCION DE ";
        public static String REFRESH = "REFRESH";
        public static String PERSISTENCE_CACHE_STOREMODE = "javax.persistence.cache.storeMode";
        public static String ILLEGALSTATEEXCEPTION = "IllegalStateException ";
        public static String QUERYTIMEOUTEXCEPTION = "QueryTimeoutException ";
        public static String TRANSACTIONREQUIREDEXCEPTION = "TransactionRequiredException ";
        public static String PESSIMISTICLOCKEXCEPTION = "PessimisticLockException ";
        public static String PERSISTENCEEXCEPTION = "PersistenceException ";

        public static String SECURITY_KEY_FIRST_LOGIN = "flsegurossucre.2018";
        public static String SECURITY_SALT = "$2a$06$.rCVZVOThsIa97pEDOxvGuRRgzG64bvtJ0938xuqzv18d3ZpQhstC";

        /**
         * MAIL CONSTANTS
         */

        public static String MAIL_SMTP = "smtp";
        public static String MAIL_POP3 = "pop3s";
        public static String MAIL_IMAP = "imaps";
        public static String MAIL_INBOX = "INBOX";
        public static String MAIL_SENT = "SENT";
        public static String MAIL_OUTBOX = "OUTBOX";
        public static String MAIL_MIME_TYPE_TEXT = "text/HTML";
        public static String MAIL_MIME_TYPE_PNG = "image/png";
        public static String MAIL_MIME_TYPE_PDF = "application/pdf";
        public static String MAIL_MIME_TYPE_XLS = "application/xhtml+xml";
        public static String MAIL_SUB_TYPE_HTML = "html";
        public static String MAIL_DEFAULT_CHARSET = "UTF-8";
        public static String MAIL_SMTP_HOST_PROPS = "mail.smtp.host";
        public static String MAIL_SMTP_PORT_PROPS = "mail.smtp.port";
        public static String MAIL_SMTP_AUTH_PROPS = "mail.smtp.auth";
        public static String MAIL_SMTP_TLS_PROPS = "mail.smtp.starttls.enable";
        public static String MAIL_SMTP_SOCKET_FACTORY_PORT_PROPS = "mail.smtp.socketFactory.port";
        public static String MAIL_SMTP_SOCKET_FACTORY_CLASS_PROPS = "mail.smtp.socketFactory.class";
        public static String MAIL_SMTP_SOCKET_FACTORY_CLASS_VALUE_PROPS = "javax.net.ssl.SSLSocketFactory";

        public static String MAIL_POP3_HOST_PROPS = "mail.pop3.host";
        public static String MAIL_POP3_PORT_PROPS = "mail.pop3.port";
        public static String MAIL_POP3_AUTH_PROPS = "mail.pop3.auth";
        public static String MAIL_POP3_TLS_PROPS = "mail.pop3.starttls.enable";
        public static String MAIL_POP3_SOCKET_FACTORY_PORT_PROPS = "mail.pop3.socketFactory.port";
        public static String MAIL_POP3_SOCKET_FACTORY_CLASS_PROPS = "mail.pop3.socketFactory.class";
        public static String MAIL_POP3_SOCKET_FACTORY_CLASS_VALUE_PROPS = "javax.net.ssl.SSLSocketFactory";

        public static String MAIL_IMAP_STORE_PROTOCOL_PROPS = "mail.store.protocol";
        public static String MAIL_IMAP_PORT_PROPS = "mail.imap.port";
        public static String MAIL_IMAP_AUTH_PROPS = "mail.imap.auth";
        public static String MAIL_IMAP_TLS_PROPS = "mail.imap.starttls.enable";
        public static String MAIL_IMAP_SOCKET_FACTORY_PORT_PROPS = "mail.imap.socketFactory.port";
        public static String MAIL_IMAP_SOCKET_FACTORY_CLASS_PROPS = "mail.imap.socketFactory.class";
        public static String MAIL_IMAP_SOCKET_FACTORY_CLASS_VALUE_PROPS = "javax.net.ssl.SSLSocketFactory";

        public static String MAIL_MULTIPART_IMAGE = "<image>";

        private Constantes()
        {

        }

        public class EstadosPista
        { 
            public static string ACTIVO= "ACT";
            public static string INACTIVO = "INA";
            public static string RECHAZADO = "RECHAZADO";
            public static string RECHAZOCONFIRMADO = "RECHAZOCONFIRM";
            public static string CANCELADO = "CANCELADO";
            public static string REGISTRADO = "REGISTRADO";
            public static string DUPLICADO = "DUPLICADO";
            public static string BPM = "BPM";
        }

        public class EstadosPistasNew
        {
            public static string REVISION_MANUAL = "REVISION MANUAL";
            public static string RECHAZADO = "RECHAZADO";
            public static string PRE_APROBADO = "PRE APROBADO";
            public static string DUPLICADO = "DUPLICADO";
            public static string COMPLETO = "COMPLETO";
            public static string INPROCESS = "INPROCESS";
            public static string APROBADO = "APROBADO";
            public static string VINCULAR = "VINCULAR";
        }
        public class FrecuenciaPago
        {
            public static string M = "M";
            
        }
        public class None
        {
            public static string NONE = "None";
            public static string FALSE = "false";

        }
        public class TipoCuentaBanco
        {
            public static string CORRIENTE = "CORRIENTE";
            public static string AHORRO = "AHORROS";

        }
    }
}

// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,
  rootContext:"",
  isMockEnabled: false, // You have to switch this, when your real back-end is done
  urlCorePista:"http://38.67.136.34:5001/gestion-pista-rest/resources/" ,
  //urlCorePista:"https://localhost:44343/gestion-pista-rest/resources/",
  //urlCorePista:"https://localhost:44343/gestion-pista-rest/resources/",
  apiUrlGeneric:"http://186.4.199.176:18080/generic-relative-rest/resources/",
  apiUrlMail:"http://38.67.136.34:5000/sendMmail?guardar=guardar",
  apiUrlListMongo:"http://38.67.136.34:5000/findByParam",
  apiUrlLoging:"https://pruebas.mfcapitalgroup.com/edimcapruebasWA/api/LoginPistas",
  tokenKey:"RE000",
  userdata:"RE001",
  userKey:"RE002",
  rolKey:"RE003",
  emailKey:"RE004",
  sucursalKey:"RE004",
  comodin:"9KxQ==",
  mongoColNotif:"col_notificacion",
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.

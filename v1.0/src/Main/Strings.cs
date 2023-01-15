using System;
using System.Collections.Generic;
using System.Text;

namespace Janda
{
	public class Strings
	{
		public const string strLogoCaption = "Transport for London";

		public const string strConnecting = "Connecting...";
		public const string strReceivingData = "Receiving data...";
		public const string strProcessingData = "Processing data...";
		public const string strLoadingData = "Loading data...";
		public const string strWaitForResponse = "Waiting for response...";

		public const string strSessionExpired = "Session expired. Search again...";

		public const string strExitConfirm = "Do you want to exit?";
		public const string strExitCaption = "Confirmation";


		
		/// <summary>
		/// 0 - value of multiple options
		/// 1 - origin type
		/// </summary>
		public const string strMultipleFromFormat = "&placeState_origin=identified&place_origin=31117000:20060403&nameState_origin=list&name_origin={0}&type_origin={1}";
		public const string strMultipleToFormat = "&placeState_destination=identified&place_destination=31117000:20060403&nameState_destination=list&name_destination={0}&type_destination={1}";


		/// <summary>
		/// 0 - sessionID
		/// 1 - strMultipleFromFormat
		/// 2 - strMultipleToFormat
		/// </summary>
		public const string urlMultipleContinueFormat = "http://journeyplanner.tfl.gov.uk/user/XSLT_TRIP_REQUEST2?language=en&requestID=1&command=&itdLPxx_request=&itdLPxx_tubeMap=&calculateDistance=1&Submit=&{0}{1}{2}";
		                                                                                                       // language=en&requestID=1&sessionID=JP23_1194361836&command=&itdLPxx_request=&itdLPxx_tubeMap=&calculateDistance=1&placeState_origin=identified&place_origin=31117000%3A20060403&name_origin=0%3A1&type_origin=stop&nameState_origin=list&Submit=

		/// <summary>
		/// 0 - from place name
		/// 1 - from palce type
		/// 2 - to place name
		/// 		/// 3 - to place type
		/// </summary>
		public const string urlLeaveNowFormat = "http://journeyplanner.tfl.gov.uk/user/XSLT_TRIP_REQUEST2?language=en&execInst=&place_origin=London&place_destination=London&sessionID=0&ptOptionsActive=-1&name_origin={0}&type_origin={1}&name_destination={2}&type_destination={3}";
		public const string urlTripFormat = "http://journeyplanner.tfl.gov.uk/user/XSLT_TRIP_REQUEST2?language=en&{0}&requestID=1&command={1}";
		



		/// <summary>
		/// http://journeyplanner.tfl.gov.uk/user/XSLT_TRIP_REQUEST2?language=en&sessionID=0&requestID=0&ptOptionsActive=1&itOptionsActive=1&imparedOptionsActive=1&ptAdvancedOptions=1&advOptActive_2=1&advOpt_2=1&execInst=normal&command=&itdLPxx_request=&itdLPxx_view=&itdLPxx_tubeMap=&calculateDistance=1&name_origin=kingston&nameState_origin=notidentified&nameDefaultText_origin=start&type_origin=stop&place_origin=London&name_destination=bank&nameState_destination=notidentified&nameDefaultText_destination=end&type_destination=stop&place_destination=London&itdTripDateTimeDepArr=dep&itdDateDay=27&itdDateYearMonth=200810&itdTimeHour=21&itdTimeMinute=35&routeType=LEASTTIME&name_via=Enter+location+%28optional%29&nameState_via=notidentified&nameDefaultText_via=Enter+location+%28optional%29&type_via=stop&place_via=London&placeDefaultText_via=London&includedMeans=checkbox&inclMOT_11=1&inclMOT_0=on&inclMOT_5=on&Submit=Search&trITMOTvalue101=60&trITMOTvalue=20&trITMOT=100&changeSpeed=normal";
		/// </summary>
		//public const string urlSearchFormat = "language=en&sessionID=0&requestID=0&ptOptionsActive=1&itOptionsActive=1&imparedOptionsActive=1&ptAdvancedOptions=1&advOptActive_2=1&advOpt_2=1&execInst=normal&command=&itdLPxx_request=&itdLPxx_view=&itdLPxx_tubeMap=&calculateDistance=1&name_origin=kingston&nameState_origin=notidentified&nameDefaultText_origin=start&type_origin=stop&place_origin=London&name_destination=bank&nameState_destination=notidentified&nameDefaultText_destination=end&type_destination=stop&place_destination=London&itdTripDateTimeDepArr=dep&itdDateDay=27&itdDateYearMonth=200810&itdTimeHour=21&itdTimeMinute=35&routeType=LEASTTIME&name_via=Enter+location+%28optional%29&nameState_via=notidentified&nameDefaultText_via=Enter+location+%28optional%29&type_via=stop&place_via=London&placeDefaultText_via=London&includedMeans=checkbox&inclMOT_11=1&inclMOT_0=on&inclMOT_5=on&Submit=Search&trITMOTvalue101=60&trITMOTvalue=20&trITMOT=100&changeSpeed=normal";


		/// <summary>
		/// 0 - from place name
		/// 1 - from palce type
		/// 2 - to place name
		/// 3 - to place type
		/// 4 - transport parameters
		/// </summary>
		public const string urlSearchFormat = "http://journeyplanner.tfl.gov.uk/user/XSLT_TRIP_REQUEST2?language=en&execInst=&place_origin=London&place_destination=London&sessionID=0&ptOptionsActive=-1&name_origin={0}&type_origin={1}&name_destination={2}&type_destination={3}&Submit=Search{4}";


		/// <summary>
		/// 0 - session id
		/// 1 - result index
		/// </summary>
		public const string urlSummaryFormat = "http://journeyplanner.tfl.gov.uk/user/XSLT_TRIP_REQUEST2?language=en&{0}&requestID=1&tripSelector{1}=1&itdLPxx_view=detail&tripSelection=on&command=nop&calculateDistance=1";
		                                                                                                                            
	}
}

﻿// The MIT License (MIT)
//
// Copyright (c) 2014 Beanstream Internet Commerce Corp, Digital River, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
using System;
using Beanstream.Api.SDK.Domain;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Beanstream.Api.SDK
{
	public class PaymentProfile
	{
		[JsonProperty(PropertyName = "customer_code")]
		public string CustomerCode { get; set; }

		[JsonProperty(PropertyName = "modified_date")]
		public DateTime ModifiedDate { get; set; }

		/// <summary>
		/// The default card on the profile. To get all the cards call paymentProfile.getCards().
		/// </summary>
		/// <value>The card.</value>
		[JsonProperty(PropertyName = "card")]
		public Card Card { get; set; }

		[JsonProperty(PropertyName = "billing")]
		public Address Billing { get; set; }

		[JsonProperty(PropertyName = "custom")]
		public CustomFields CustomFields { get; set; }

		[JsonProperty(PropertyName = "language")]
		public string Language { get; set; }

		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		[JsonProperty(PropertyName = "last_transaction")]
		public string LastTransaction { get; set; }

		[JsonProperty(PropertyName = "comment")]
		public string Comment { get; set; }

		/// <summary>
		/// Get all cards on this profile
		/// </summary>
		/// <returns>The cards.</returns>
		/// <param name="gateway">Gateway.</param>
		public List<Card> getCards(ProfilesAPI api) {
			return api.GetCards (CustomerCode);
		}

		/// <summary>
		/// Add a card to this payment profile
		/// </summary>
		/// <returns>The card.</returns>
		/// <param name="card">Card.</param>
		/// <param name="gateway">Gateway.</param>
		public ProfileResponse AddCard(Card card, ProfilesAPI api) {
			return api.AddCard (CustomerCode, card);
		}

		public ProfileResponse UpdateCard(Card card, ProfilesAPI api) {
			return api.UpdateCard (CustomerCode, card);
		}

		public ProfileResponse RemoveCard(Card card, ProfilesAPI api) {
			return api.RemoveCard (CustomerCode, card);
		}
	}
}


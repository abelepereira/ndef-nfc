/****************************************************************************
**
** Copyright (C) 2015 Abel Pereira 
** All rights reserved.
**
** Created by Abel Pereira (2015).
**
** GNU Lesser General Public License Usage
** This file may be used under the terms of the GNU Lesser General Public
** License version 2.1 as published by the Free Software Foundation and
** appearing in the file LICENSE.LGPL included in the packaging of this
** file. Please review the following information to ensure the GNU Lesser
** General Public License version 2.1 requirements will be met:
** http://www.gnu.org/licenses/old-licenses/lgpl-2.1.html.
**
** GNU General Public License Usage
** Alternatively, this file may be used under the terms of the GNU General
** Public License version 3.0 as published by the Free Software Foundation
** and appearing in the file LICENSE.GPL included in the packaging of this
** file. Please review the following information to ensure the GNU General
** Public License version 3.0 requirements will be met:
** http://www.gnu.org/copyleft/gpl.html.
**
****************************************************************************/

namespace NdefLibrary.Ndef
{
	public enum NdefRecordFlags : byte
	{
		/// <summary>
		///     The TNF field value indicates the structure of the value of the TYPE field. This is the bit 0 for TNF value.
		/// </summary>
		Tnf0 = 0x1,

		/// <summary>
		///     The TNF field value indicates the structure of the value of the TYPE field. This is the bit 2 for TNF value.
		/// </summary>
		Tnf1 = 0x2,

		/// <summary>
		///     The TNF field value indicates the structure of the value of the TYPE field. This is the bit 2 for TNF value.
		/// </summary>
		Tfn2 = 0x4,

		/// <summary>
		///     The IL flag is a 1-bit field indicating, if set, that the ID_LENGTH field is present in the header as
		///     a single octet. If the IL flag is zero, the ID_LENGTH field is omitted from the record header and
		///     the ID field is also omitted from the record.
		/// </summary>
		IdLength = 0x8,

		/// <summary>
		///     The SR flag is a 1-bit field indicating, if set, that the PAYLOAD_LENGTH field is a single octet.
		///     This short record layout is intended for compact encapsulation of small payloads which will fit
		///     within PAYLOAD fields of size ranging between 0 to 255 octets.
		/// </summary>
		ShortRecord = 0x10,

		/// <summary>
		///     The CF flag is a 1-bit field indicating that this is either the first record chunk or a middle record chunk of a
		///     chunked payload.
		/// </summary>
		ChunkFlag = 0x20,

		/// <summary>
		///     The ME flag is a 1-bit field that when set indicates the end of an NDEF message.
		/// </summary>
		MessageEnd = 0x40,

		/// <summary>
		///     The MB flag is a 1-bit field that when set indicates the start of an NDEF message.
		/// </summary>
		MessageBegin = 0x80
	}
}